using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MobileOperator
{
    [Serializable]
    [AccountValidation]
    public class MobileAccount
    {
        private static int _count;

        public event EventHandler<ActionEventArgs> Message;
        public event EventHandler<ActionEventArgs> Call;
                
        public int Number { get; }
        public Dictionary<int, string> Contacts { get; }

        [Required(ErrorMessage = "Acoount owner name was not specified")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Name may contains only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Acoount owner surname was not specified")]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Surname may contains only letters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Acoount owner birth date was not specified")]
        [DataType(dataType: DataType.Date)]
        public DateTime BirthDate { get; set; }

        [EmailAddress(ErrorMessage = "Incorrect email adress")]
        public string Email { get; set; }

        public MobileAccount()
        {
            _count++;
            Number = _count;
            Contacts = new Dictionary<int, string>();
        }

        public MobileAccount(string name, string surname, DateTime birthDate, string email)
        {
            Number = _count;
            _count++;
            Contacts = new Dictionary<int, string>();

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
            else if(senderNumber.Equals(0))
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
    }
}
