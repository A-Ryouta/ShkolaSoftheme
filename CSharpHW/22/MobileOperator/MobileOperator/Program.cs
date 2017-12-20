using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MobileOperator
{
    class Program
    {
        static void Main()
        {
            MobileOperator life = new MobileOperator();

            using (StreamReader file = File.OpenText(@"d:\accounts.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JArray o = (JArray)JToken.ReadFrom(reader);
                List<MobileAccount> accounts  = o.ToObject<List<MobileAccount>>();
                life.LoadAccounts(accounts);
            }

            foreach (var account in life.Accounts)
            {
                Console.WriteLine("{0} {1}", account.Number, account.Name);
            }
         
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
