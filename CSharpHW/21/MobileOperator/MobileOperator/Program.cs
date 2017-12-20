using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using ProtoBuf;
using Newtonsoft.Json;

namespace MobileOperator
{
    class Program
    {
        static void Main()
        {
            MobileOperator life = new MobileOperator();

            for (int i = 0; i < 10000; i++)
            {
                life.AddAccount("Jerry");
            }

            var accounts = life.GetAccounts();
            
            var start = DateTime.Now;
            using (var fs = new FileStream("accounts.dat", FileMode.OpenOrCreate))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, accounts);
            }
            var end = DateTime.Now;
            Console.WriteLine("Binary: {0}", end - start);

            
            start = DateTime.Now;
            using (var fs = new FileStream("accounts.xml", FileMode.OpenOrCreate))
            {
                var xmlFormatter = new XmlSerializer(typeof(List<MobileAccount>));
                xmlFormatter.Serialize(fs, accounts);
            }
            end = DateTime.Now;
            Console.WriteLine("Xml: {0}", end - start);
            
            start = DateTime.Now;
            using (var sw = File.CreateText("accounts.json"))
            {
                var jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(sw, accounts);
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
