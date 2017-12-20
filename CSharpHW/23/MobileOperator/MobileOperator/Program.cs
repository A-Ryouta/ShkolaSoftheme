using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MobileOperator
{
    class Program
    {
        static void Main()
        {
            MobileOperator life = new MobileOperator();

            MobileAccount pedro = life.AddAccount();
            MobileAccount marta = life.AddAccount();
            MobileAccount orest = life.AddAccount();
            MobileAccount jack = life.AddAccount();
            MobileAccount victoria = life.AddAccount();


            victoria.AddContact(1, "Pedro");
            victoria.AddContact(4, "Jack");
            jack.AddContact(2, "Marta");

            pedro.SendMessage(5, "Hello Victoria!");

            marta.TryToCall(4);
            marta.TryToCall(5);
            marta.SendMessage(4, "Hi");

            orest.SendMessage(2, "Meeting at 5 p.m.");

            jack.TryToCall(7);
            jack.TryToCall(2);
            jack.SendMessage(2, "Answer pls");

            victoria.TryToCall(2);
            victoria.SendMessage(1, "Hi Pedro. How are you?");
            victoria.TryToCall(4);
            victoria.TryToCall(2);

            life.TakeCallsByNumber(2);

            Console.ReadLine();
        }

        private static void Validate(MobileAccount account)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(account);
            if (!Validator.TryValidateObject(account, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("User {0} {1} is Valid", account.Name, account.Number);
            }
        }
    }
}
