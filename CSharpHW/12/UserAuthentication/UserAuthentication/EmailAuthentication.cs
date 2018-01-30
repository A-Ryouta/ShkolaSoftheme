using System;

namespace UserAuthentication
{
    internal class EmailAuthentication : IAuthenticator
    {
        public string LoginCheck { get; set; }
        public string PasswordCheck { get; set; }

        public bool AuthenticateUser(IUser user)
        {
            if (user.Email != LoginCheck) return false;

            if (user.Password == PasswordCheck)
            {
                Console.WriteLine(user.GetFullInfo());
                return true;
            }

            Console.WriteLine("Incorrect password");

            return true;
        }
    }
}
