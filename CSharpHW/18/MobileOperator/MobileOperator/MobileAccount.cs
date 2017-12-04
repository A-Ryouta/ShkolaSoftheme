using System;
using System.Collections.Generic;

namespace MobileOperator
{
    internal class MobileAccount
    {
        public delegate void AccountActionsHandler(MobileAccount sender, ActionEventArgs e);
        public event AccountActionsHandler Message;
        public event AccountActionsHandler Call;

        public readonly int Number;
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

        public void TakeMessage(MobileAccount sender, ActionEventArgs e)
        {
            if (e.Receiver == Number)
            {
                if (Contacts.ContainsKey(sender.Number))
                {
                    Console.WriteLine("Take message from {0} : {1}", Contacts[sender.Number], e.Message);
                }
                else
                {
                    Console.WriteLine("Take message from {0} : {1}", sender.Number, e.Message);
                }
            }
        }

        public void TakeCall(MobileAccount sender, ActionEventArgs e)
        {
            if (e.Receiver == Number)
            {
                if (Contacts.ContainsKey(sender.Number))
                {
                    Console.WriteLine("Incoming call from {0}", Contacts[sender.Number]);
                }
                else
                {
                    Console.WriteLine("Incoming call from {0}", sender.Number);
                }
            }
        }
    }
}
