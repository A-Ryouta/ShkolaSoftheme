using System;
using System.Collections.Generic;

namespace UserAuthentication
{
    internal class Program
    {
        private static void Main()
        {
            var users = new List<User>
            {
                new User("Pavlo", "12345", new DateTime(2017, 10, 12, 14, 58, 02)),
                new User("Nuclear", "agrom_21", new DateTime(2017, 11, 17, 16, 02, 11)),
                new User("Skadabr@gmail.com", "secretFrom_all01", new DateTime(2017, 06, 06, 22, 11, 00)),
                new User("Andrew007@hotmail.com", "just_in_time", new DateTime(2017, 11, 10, 09, 34, 34))
            };
            
            string login;
            string password;

            do
            {
                Console.WriteLine("Enter username or email:");
                login = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (login == null)
                {
                    Console.WriteLine("Enter your login");
                    continue;
                }

                Authenticate(login, password, users);

            } while (login != "exit" && password != "exit");
        }

        private static void Authenticate(string login, string password, ICollection<User> users)
        {
            IAuthenticator auth;

            if (login.Contains("@"))
            {
                auth = new EmailAuthentication
                {
                    LoginCheck = login,
                    PasswordCheck = password
                };
            }
            else
            {
                auth = new UsernameAuthentication
                {
                    LoginCheck = login,
                    PasswordCheck = password
                };
            }
            
            var found = false;

            foreach (var user in users)
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