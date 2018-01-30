using System;

namespace UserAuthentication
{
    internal class User : IUser
    {
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }
        public DateTime LastAuthentication { get; set; }

        public User(string login, string pass, DateTime dt)
        {
            if (login.Contains("@"))
            {
                Email = login;
            }
            else
            {
                Name = login;
            }
            Password = pass;
            LastAuthentication = dt;
        }
        
        public string GetFullInfo()
        {
            return (Email == string.Empty) ? $"{Name} we saw you last time at {LastAuthentication}"
                : $"{Email} we saw you last time at {LastAuthentication}";            
        }   
    }
}
