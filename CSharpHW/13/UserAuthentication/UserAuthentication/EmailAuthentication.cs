using System;

namespace UserAuthentication
{
    class EmailAuthentication : IAuthenticator
    {
        public string LoginCheck { get; set; }
        public string PasswordCheck { get; set; }
        public bool AuthenticateUser(IUser user)
        {
            var found = false;
            if(user.Password == PasswordCheck && user.Email == LoginCheck)
            {
                found = true;
                Console.WriteLine(user.GetFullInfo());
                user.LastAuthentication = DateTime.Now;
            }
            else if (user.Email == LoginCheck)
            {
                found = true;
                Console.WriteLine("Incorrect password");
            }
            return found;
        }
    }
}
