using System;
using System.Collections.Generic;

namespace UserAuthentication
{
    class Program
    {
        static void Main()
        {
            UserDataBase dataBase = new UserDataBase();

            DataBaseDemonstrateFunction(dataBase);

            var login = string.Empty;
            var password = string.Empty;

            do
            {
                Console.WriteLine("Enter username or email:");
                login = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (login == string.Empty || password == string.Empty)
                {
                    Console.WriteLine("You need to input login and password.\n");
                }
                else
                {
                    Authenticate(login, password, dataBase.Users, login.Contains("@") ? "email" : "username");
                }
            } while (login != "exit" && password != "exit");
        }

        static void Authenticate(string login, string password, List<IUser> users, string type)
        {
            dynamic auth;

            if (type == "username")
            {
                auth = new UsernameAuthentication();
            }
            else
            {
                auth = new EmailAuthentication();
            }

            auth.LoginCheck = login;
            auth.PasswordCheck = password;
            
            foreach (var user in users)
            {
                if (auth.AuthenticateUser(user))
                {
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("Login failed. We added new user with current data.");
            users.Add(new User(login, password, DateTime.Now));
            Console.WriteLine();
        }

        static void DataBaseDemonstrateFunction(UserDataBase uDB)
        {
            Console.WriteLine(uDB.Find("Mukuta"));

            uDB.Add(new User("Pavlo", "12345", new DateTime(2017, 10, 12, 14, 58, 02)));
            uDB.Add(new User("Mukuta", "aggro", new DateTime(2017, 11, 17, 16, 02, 11)));
            uDB.Add(new User("Skt@gmail.com", "secret", new DateTime(2017, 06, 06, 22, 11, 00)));
            uDB.Add(new User("Andrew007@hotmail.com", "in_time", new DateTime(2017, 11, 10, 09, 34, 34)));

            Console.WriteLine(uDB.Find("Mukuta"));
            Console.WriteLine();

            Console.WriteLine(uDB.GetAll());
            Console.WriteLine();

            uDB.Dispose();
            Console.WriteLine();
        }
    }
}