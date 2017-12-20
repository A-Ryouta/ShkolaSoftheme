using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MobileOperator
{
    [Serializable]
    public class MobileOperator
    {
        [NonSerialized]
        private readonly List<Action> _journal = new List<Action>();
        private XmlDocument _xJournal = new XmlDocument();
        public List<MobileAccount> Accounts { get; }

        public MobileOperator()
        {
            Accounts = new List<MobileAccount>();
            XmlDeclaration xmlDeclaration = _xJournal.CreateXmlDeclaration("1.0", "utf-8", null);
            _xJournal.AppendChild(xmlDeclaration);
            XmlElement a = _xJournal.CreateElement("Journal");            
            _xJournal.AppendChild(a);
            _xJournal.Save(@"journal.xml");
        }

        public List<MobileAccount> GetAccounts()
        {
            return Accounts;
        }

        public MobileAccount AddAccount(string name = null, string surname = null,
            DateTime birthDate = default(DateTime), string email = null)
        {
            MobileAccount current = new MobileAccount(name, surname, birthDate, email);
            Accounts.Add(current);
            current.Message += TransferMessage;
            current.Call += Calling;

            return current;
        }

        public AdminAccount AddAdmin(string name, string surname, DateTime birthDate, string email)
        {
            AdminAccount current = new AdminAccount(name, surname, birthDate, email);
            current.MessageToAll += TransferMessage;

            return current;
        }

        public void MostPopularAccounts()
        {
            var accounts = _journal
                .GroupBy(x => x.Receiver)
                .OrderByDescending(x => x.Count())
                .Take(3)
                .Select(x => x.Key);

            Console.WriteLine("Most popular accounts:");
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }

        public void MostActiveAccounts()
        {
            var accounts = _journal
                .Select(x => new { x.Receiver, x.Type })
                .GroupBy(x => x.Receiver)
                .OrderByDescending(x => x.Count())
                .Take(3)
                .Select(x => x.Key);

            Console.WriteLine("Most active accounts:");
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }

        public void TakeCallsByNumber(int number)
        {
            var xmlDoc = XDocument.Load("journal.xml");
            var xRoot = xmlDoc.Root;

            string num = number.ToString();

            var query = xRoot.Descendants("receiver")
                .Where(x => (string)x == num);                

            foreach (var q in query)
            {
                Console.WriteLine(q.Value);
            }
        }

        private void AddOperationToXml(int sender, int receiver, string message = null)
        {            
            XmlElement actionElement = _xJournal.CreateElement("Action");

            XmlElement senderAttribute = _xJournal.CreateElement("sender");
            senderAttribute.InnerText = sender.ToString();
            XmlElement receiverAttribute = _xJournal.CreateElement("receiver");
            receiverAttribute.InnerText = receiver.ToString();

            XmlElement typeAttribute = _xJournal.CreateElement("type");            

            actionElement.AppendChild(senderAttribute);
            actionElement.AppendChild(receiverAttribute);

            if (message != null)
            {
                typeAttribute.InnerText = OperationTypes.Message.ToString();
                XmlElement messageAttribute = _xJournal.CreateElement("message");
                messageAttribute.InnerText = message;
                actionElement.AppendChild(typeAttribute);
                actionElement.AppendChild(messageAttribute);
            }
            else
            {
                typeAttribute.InnerText = OperationTypes.Call.ToString();
                actionElement.AppendChild(typeAttribute);
            }
            
            _xJournal.DocumentElement?.AppendChild(actionElement);

            _xJournal.Save(@"journal.xml");
        }

        private void TransferMessage(object sender, ActionEventArgs e)
        {
            var account = sender as MobileAccount;

            if (account is AdminAccount)
            {
                foreach (MobileAccount acc in Accounts)
                {
                    _journal.Add(new Action(account.Number, e.Receiver, OperationTypes.Message, e.Message));
                    AddOperationToXml(account.Number, e.Receiver, e.Message);
                    acc.TakeMessage(0, e.Message);
                }
            }
            else if (account != null && Accounts.Any(x => x.Number == e.Receiver))
            {
                _journal.Add(new Action(account.Number, e.Receiver, OperationTypes.Message, e.Message));
                AddOperationToXml(account.Number, e.Receiver, e.Message);
                Accounts[e.Receiver].TakeMessage(account.Number, e.Message);
            }
            else
            {
                Console.WriteLine("Failed to send. This number doesn`t exist.");
            }
        }

        private void Calling(object sender, ActionEventArgs e)
        {
            var account = sender as MobileAccount;

            if (account != null && Accounts.Any(x => x.Number == e.Receiver))
            {
                _journal.Add(new Action(account.Number, e.Receiver, OperationTypes.Call));
                AddOperationToXml(account.Number, e.Receiver);
                Accounts[e.Receiver].TakeCall(account.Number);
            }
            else
            {
                Console.WriteLine("Failed to send. This number doesn`t exist.");
            }
        }
    }
}
