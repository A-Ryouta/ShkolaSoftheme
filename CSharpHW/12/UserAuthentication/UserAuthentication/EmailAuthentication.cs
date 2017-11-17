using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication
{
    class EmailAuthentication : IAuthenticator
    {
        public string EmailCheck { get; set; }
        public string PasswordCheck { get; set; }
        public bool AuthenticateUser(IUser user)
        {
            var found = false;
            if(user.Email == EmailCheck && user.Password == PasswordCheck)
            {
                found = true;
                Console.WriteLine(user.GetFullInfo());
            }
            else if (user.Email == EmailCheck)
            {
                found = true;
                Console.WriteLine("Incorrect password");
            }
            return found;
        }
    }
}
