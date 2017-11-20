using System;

namespace UserAuthentication
{
    class User : IUser
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime LastAuthentication { get; set; }
        public User(string login, string pass, DateTime dt)
        {
            Name = (login.Contains("@")) ? string.Empty : login;
            Email = (login.Contains("@")) ? login : string.Empty;                           
            Password = pass;
            LastAuthentication = dt;
        }        
        public string GetFullInfo()
        {
            return (Email == String.Empty) ? string.Format("{0} we saw you last time at {1}", Name, LastAuthentication) :
                string.Format("{0} we saw you last time at {1}", Email, LastAuthentication);            
        }   
    }
}
