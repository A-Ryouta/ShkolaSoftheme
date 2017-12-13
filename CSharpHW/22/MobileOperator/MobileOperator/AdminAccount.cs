using System;

namespace MobileOperator
{
    public class AdminAccount : MobileAccount
    {
        public event EventHandler<ActionEventArgs> MessageToAll;
        public int Number { get; }

        public AdminAccount(string name, string surname, DateTime birthDate, string email)
            : base(name, surname, birthDate, email)
        {
            Number = 0;
        }

        public void SendMessage(string message)
        {
            MessageToAll?.Invoke(this, new ActionEventArgs(message));
        }
    }
}