using System;
using System.Collections.Generic;

namespace MobileOperator
{
    internal class MobileOperator
    {
        public delegate void OperatorActionsHandler(MobileAccount sender, ActionEventArgs e);
        public event OperatorActionsHandler Message;
        public event OperatorActionsHandler Call;

        public Dictionary<int, MobileAccount> Accounts { get; }

        public MobileOperator()
        {
            Accounts = new Dictionary<int, MobileAccount>();
        }

        public MobileAccount AddAccount(int number)
        {
            MobileAccount current = new MobileAccount(number);
            Accounts.Add(number, current);
            current.Message += TransferMessage;
            current.Call += Calling;

            return current;
        }

        private void TransferMessage(MobileAccount sender, ActionEventArgs e)
        {
            if (Accounts.ContainsKey(e.Receiver))
            {
                Message?.Invoke(sender, new ActionEventArgs(e.Receiver, e.Message));
            }
            else
            {
                Console.WriteLine("Failed to send. This number doesn`t exist.");
            }
        }

        private void Calling(MobileAccount sender, ActionEventArgs e)
        {
            if (Accounts.ContainsKey(e.Receiver))
            {
                Call?.Invoke(sender, new ActionEventArgs(e.Receiver));
            }
            else
            {
                Console.WriteLine("This number doesn`t exist.");
            }
        }
    }
}
