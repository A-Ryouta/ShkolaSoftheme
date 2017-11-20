using System;

namespace UserAuthentication
{
    class UsernameAuthentication : IAuthenticator
    {
        public string LoginCheck { get; set; }
        public string PasswordCheck { get; set; }
        public bool AuthenticateUser(IUser user)
        {
            var found = false;
            if (user.Password == PasswordCheck && user.Name == LoginCheck)
            {
                found = true;
                Console.WriteLine(user.GetFullInfo());
                user.LastAuthentication = DateTime.Now;
            }
            else if(user.Name == LoginCheck)
            {
                found = true;
                Console.WriteLine("Incorrect password");
            }
            return found;      
        }
    }
}
