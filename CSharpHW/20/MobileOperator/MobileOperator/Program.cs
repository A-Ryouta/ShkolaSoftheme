using System;

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
            
            
            victoria.AddContact(111, "Pedro");
            victoria.AddContact(444, "Jack");
            jack.AddContact(222, "Marta");

            pedro.SendMessage(555, "Hello Victoria!");

            marta.TryToCall(444);
            marta.TryToCall(555);
            marta.SendMessage(444, "Hi");

            orest.SendMessage(222, "Meeting at 5 p.m.");

            jack.TryToCall(777);
            jack.TryToCall(222);
            jack.SendMessage(222, "Answer pls");

            victoria.TryToCall(222);
            victoria.SendMessage(111, "Hi Pedro. How are you?");
            victoria.TryToCall(444);
            victoria.TryToCall(222);

            life.MostPopularAccounts();
            life.MostActiveAccounts();

            Console.ReadLine();
        }        
    }
}
