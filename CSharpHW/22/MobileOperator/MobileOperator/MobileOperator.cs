using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    [Serializable]
    public class MobileOperator
    {
        [NonSerialized]
        private readonly List<Action> _journal = new List<Action>();
        public List<MobileAccount> Accounts { get; set; }

        public MobileOperator()
        {
            Accounts = new List<MobileAccount>();
        }

        public void LoadAccounts(List<MobileAccount> accounts)
        {
            Accounts = accounts;
        }

        public List<MobileAccount> GetAccounts()
        {
            return Accounts;
        }

        public void AddAccount(string name = null, string surname = null,
            DateTime birthDate = default(DateTime), string email = null)
        {
            MobileAccount current = new MobileAccount(name, surname, birthDate, email);
            Accounts.Add(current);
            current.Message += TransferMessage;
            current.Call += Calling;
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

        private void TransferMessage(object sender, ActionEventArgs e)
        {
            var account = sender as MobileAccount;

            if (account is AdminAccount)
            {
                foreach (MobileAccount acc in Accounts)
                {
                    _journal.Add(new Action(account.Number, e.Receiver, OperationTypes.Message, e.Message));
                    acc.TakeMessage(0, e.Message);
                }
            }
            else if (account != null && Accounts.Any(x => x.Number == e.Receiver))
            {
                _journal.Add(new Action(account.Number, e.Receiver, OperationTypes.Message, e.Message));
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
                Accounts[e.Receiver].TakeCall(account.Number);
            }
            else
            {
                Console.WriteLine("Failed to send. This number doesn`t exist.");
            }
        }
    }
}
