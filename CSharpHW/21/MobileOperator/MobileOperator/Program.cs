using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace MobileOperator
{
    class Program
    {
        static void Main()
        {
            MobileOperator life = new MobileOperator();

            for (int i = 0; i < 10000; i++)
            {
                life.AddAccount();
            }

            MobileAccount[] accounts = life.Accounts.Values.ToArray();
            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //using (var fs = new FileStream("accounts.dat", FileMode.OpenOrCreate))
            //{
            //    binaryFormatter.Serialize(fs, life.Accounts);
            //}

            var xmlFormatter = new XmlSerializer(typeof(MobileAccount));
            using (var fs = new FileStream("accounts.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fs, accounts);
            }

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MobileAccount));
            using (var fs = new FileStream("accounts.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, accounts);
            }

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
