using System;
using System.Runtime.Remoting.Lifetime;

namespace MobileOperator
{
    class Program
    {
        static void Main()
        {
            MobileOperator life = new MobileOperator();

            MobileAccount pedro = life.AddAccount(111);
            MobileAccount marta = life.AddAccount(222);
            MobileAccount orest = life.AddAccount(333);
            MobileAccount jack = life.AddAccount(444);
            MobileAccount victoria = life.AddAccount(555);

            foreach (var mobileAccount in life.Accounts)
            {
                life.Message += mobileAccount.Value.TakeMessage;
                life.Call += mobileAccount.Value.TakeCall;
            }
            
            victoria.AddContact(111, "Pedro");
            victoria.AddContact(444, "Jack");
            jack.AddContact(222, "Marta");

            pedro.SendMessage(555, "Hello Victoria!");
            marta.TryToCall(444);
            orest.SendMessage(222, "Meeting at 5 p.m.");
            jack.TryToCall(777);
            victoria.TryToCall(222);

            Console.ReadLine();
        }        
    }
}
