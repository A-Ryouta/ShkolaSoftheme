using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using ProtoBuf;

namespace MobileOperator
{
    [Serializable]
    [ProtoContract]
    public class MobileAccount : IValidatableObject
    {
        [NonSerialized]
        private static int _count;

        public event EventHandler<ActionEventArgs> Message;
        public event EventHandler<ActionEventArgs> Call;

        [ProtoMember(1)]
        public int Number { get; }
        [ProtoMember(2)]
        public XmlSerializableDictionary<int, string> Contacts { get; }

        [ProtoMember(3)]
        public string Name { get; set; }
        [ProtoMember(4)]
        public string Surname { get; set; }
        [ProtoMember(5)]
        public DateTime BirthDate { get; set; }
        [ProtoMember(6)]
        public string Email { get; set; }

        public MobileAccount()
        {
            
        }

        public MobileAccount(string name, string surname, DateTime birthDate, string email)
        {
            Number = _count;
            _count++;
            Contacts = new XmlSerializableDictionary<int, string>();

            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Email = email;
        }

        public void AddContact(int number, string name)
        {
            Contacts.Add(number, name);
        }

        public void SendMessage(int receiver, string message)
        {
            Message?.Invoke(this, new ActionEventArgs(receiver, message));
        }

        public void TryToCall(int receiver)
        {
            Call?.Invoke(this, new ActionEventArgs(receiver));
        }

        public void TakeMessage(int senderNumber, string message)
        {
            if (Contacts.Any(u => u.Key == senderNumber))
            {
                Console.WriteLine("Take message from {0} : {1}", Contacts[senderNumber], message);
            }
            else if (senderNumber.Equals(0))
            {
                Console.WriteLine("Take message from Life : {0}", message);
            }
            else
            {
                Console.WriteLine("Take message from {0} : {1}", senderNumber, message);
            }

        }

        public void TakeCall(int senderNumber)
        {
            if (Contacts.Any(u => u.Key == senderNumber))
            {
                Console.WriteLine("Incoming call from {0}", Contacts[senderNumber]);
            }
            else
            {
                Console.WriteLine("Incoming call from {0}", senderNumber);
            }

        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Name))
            {
                errors.Add(new ValidationResult("Account owner name was not specified"));
            }
            else if (Name.Length < 3 || Name.Length > 20)
            {
                errors.Add(new ValidationResult("Name must be from 3 to 20 characters"));
            }
            if (!Regex.IsMatch(Name, @"^[a-zA-Z]+$"))
            {
                errors.Add(new ValidationResult("Name may contains only letters"));
            }

            if (string.IsNullOrEmpty(Surname))
            {
                errors.Add(new ValidationResult("Account owner surname was not specified"));
            }
            else if (Name.Length < 3 || Name.Length > 20)
            {
                errors.Add(new ValidationResult("Surname must be from 3 to 20 characters"));
            }
            if (!Regex.IsMatch(Name, @"^[a-zA-Z]+$"))
            {
                errors.Add(new ValidationResult("Surname may contains only letters"));
            }

            if (BirthDate == default(DateTime))
            {
                errors.Add(new ValidationResult("Acoount owner birth date was not specified"));
            }
            else if (BirthDate >= new DateTime(2005, 01, 01) || BirthDate <= new DateTime(1900, 01, 01))
            {
                errors.Add(new ValidationResult("You`re too young or probably dead"));
            }

            if (!Email.Contains('@'))
            {
                errors.Add(new ValidationResult("Incorrect email address"));
            }

            return errors;
        }
    }
}
