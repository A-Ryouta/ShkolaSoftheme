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

            for (int i = 0; i < 10000; i++)
            {
                life.AddAccount();
            }

            MobileAccount[] accounts = life.Accounts.Values.ToArray();

            var binaryFormatter = new BinaryFormatter();
            var start = DateTime.Now;
            using (var fs = new FileStream("accounts.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, accounts);
            }
            var end = DateTime.Now;
            Console.WriteLine("Binary: {0}", end - start);

            var xmlFormatter = new XmlSerializer(typeof(MobileAccount[]));
            start = DateTime.Now;
            using (var fs = new FileStream("accounts.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fs, accounts);
            }
            end = DateTime.Now;
            Console.WriteLine("Xml: {0}", end - start);

            var jsonFormatter = new DataContractJsonSerializer(typeof(MobileAccount[]));
            start = DateTime.Now;
            using (var fs = new FileStream("accounts.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, accounts);
            }
            end = DateTime.Now;
            Console.WriteLine("Json: {0}", end - start);

            start = DateTime.Now;
            using (var fs = new FileStream("accounts.bin", FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, accounts);
            }
            end = DateTime.Now;
            Console.WriteLine("Protobuff: {0}", end - start);
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
