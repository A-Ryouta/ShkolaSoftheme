using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User("Pavlo", "12345", new DateTime(2017, 10, 12, 14, 58, 02)));
            users.Add(new User("Nuclear", "agrom_21", new DateTime(2017, 11, 17, 16, 02, 11)));
            users.Add(new User("Skadabr@gmail.com", "secretFrom_all01", new DateTime(2017, 06, 06, 22, 11, 00)));
            users.Add(new User("Andrew007@hotmail.com", "just_in_time", new DateTime(2017, 11, 10, 09, 34, 34)));

            var login = string.Empty;
            var password = string.Empty;

            do
            {
                Console.WriteLine("Enter username or email:");
                login = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (login.Contains("@"))
                {
                    Authenticate(login, password, users, "email");
                }
                else
                {
                    Authenticate(login, password, users, "username");                    
                }
            } while (login != "exit" && password != "exit");
        }
        static void Authenticate(string login, string password, List<User> users, string type)
        {
            dynamic auth;
            if (type == "username")
            {
                auth = new UsernameAuthentication();
                auth.NameCheck = login;
            }
            else
            {
                auth = new EmailAuthentication();
                auth.EmailCheck = login;
            }

            auth.PasswordCheck = password;
            var found = false;

            foreach (User user in users)
            {
                found = auth.AuthenticateUser(user);
                if (found)
                {
                    user.LastAuthentication = DateTime.Now;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Login failed. We added new user with current data.");
                users.Add(new User(login, password, DateTime.Now));
            }
            Console.WriteLine();
        }
    }
}