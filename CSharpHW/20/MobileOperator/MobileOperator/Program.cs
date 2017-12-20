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
            
            AdminAccount admin = life.AddAdmin("Admin", "Admin"
                , new DateTime(1990, 10, 24), "LifeAdmin@fife.org");

            MobileAccount john =
                life.AddAccount("John", "Gordon", new DateTime(1994, 06, 03), "Hohoho@gmail.com");
            Validate(john);
            MobileAccount sam =
                life.AddAccount("S@m", "4wing", new DateTime(2010, 06, 03), "noSpamPls");
            Validate(sam);
            MobileAccount eve =
                life.AddAccount("Eve", "Aberfort", new DateTime(1899, 06, 03), "myemail@ukr.net");
            Validate(eve);

            admin.SendMessage("Discount for everyone!");

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
