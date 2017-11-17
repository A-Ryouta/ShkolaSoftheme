using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication
{
    class UsernameAuthentication : IAuthenticator
    {
        public string NameCheck { get; set; }
        public string PasswordCheck { get; set; }
        public bool AuthenticateUser(IUser user)
        {
            var found = false;
            if (user.Name == NameCheck && user.Password == PasswordCheck)
            {
                found = true;
                Console.WriteLine(user.GetFullInfo());
            }
            else if(user.Name == NameCheck)
            {
                found = true;
                Console.WriteLine("Incorrect password");
            }
            return found;      
        }
    }
}
