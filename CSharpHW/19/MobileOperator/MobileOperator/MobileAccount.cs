using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    internal class MobileAccount
    {
        public delegate void AccountActionsHandler(MobileAccount sender, ActionEventArgs e);
        public event EventHandler<ActionEventArgs> Message;
        public event EventHandler<ActionEventArgs> Call;

        public int Number { get; }
        public Dictionary<int, string> Contacts { get; }

        public MobileAccount(int number)
        {
            Number = number;
            Contacts = new Dictionary<int, string>();
        }

        public void AddContact(int number, string name)
        {
            Contacts.Add(number, name);
        }

        public void SendMessage(int receiver, string message)
        {
            Message?.Invoke(this, new ActionEventArgs(receiver, message));
        }

        public void TryToCall(int receiver)
        {
            Call?.Invoke(this, new ActionEventArgs(receiver));
        }

        public void TakeMessage(int senderNumber, string message)
        {
            if (Contacts.Any(u => u.Key == senderNumber))
            {
                Console.WriteLine("Take message from {0} : {1}", Contacts[senderNumber], message);
            }
            else
            {
                Console.WriteLine("Take message from {0} : {1}", senderNumber, message);
            }

        }

        public void TakeCall(int senderNumber)
        {
            if (Contacts.Any(u => u.Key == senderNumber))
            {
                Console.WriteLine("Incoming call from {0}", Contacts[senderNumber]);
            }
            else
            {
                Console.WriteLine("Incoming call from {0}", senderNumber);
            }

        }
    }
}
