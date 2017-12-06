using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    internal class MobileOperator
    {
        private readonly List<Action> _journal = new List<Action>();
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
                .Select(x => new { x.Receiver, x.Type})
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
            
            if (account != null && Accounts.ContainsKey(e.Receiver))
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

            if (account != null && Accounts.ContainsKey(e.Receiver))
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
