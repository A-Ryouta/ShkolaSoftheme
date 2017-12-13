using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using ProtoBuf;

namespace MobileOperator
{
    class Program
    {
        static void Main()
        {
            MobileOperator life = new MobileOperator();
            
            MobileAccount[] deserializeAccounts = new MobileAccount[] { };
            var jsonFormatter = new DataContractJsonSerializer(deserializeAccounts.GetType());

            using (var fs = new FileStream(@"D:\accounts.json", FileMode.Open))
            {
                deserializeAccounts = jsonFormatter.ReadObject(fs) as MobileAccount[];
            }

            life.LoadAccounts(deserializeAccounts);
         
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
