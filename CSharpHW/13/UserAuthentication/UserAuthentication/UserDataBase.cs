using System;
using System.Collections.Generic;

namespace UserAuthentication
{
    class UserDataBase : IUserDataBase
    {
        public List<IUser> Users { get; set; }

        public UserDataBase()
        {
            Users = new List<IUser>();
        }
        
        public List<IUser> GetAll()
        {
            return Users;
        }
        public bool Find(string userName)
        {
            var result = false;
            try
            {
                foreach (var user in Users)
                {
                    if (user.Name == userName)
                    {
                        result = true;
                        break;
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public void Add(IUser user)
        {
            Users.Add(user);
        }
        public void Dispose()
        {
            foreach (var user in Users)
            {
                Console.WriteLine(user.GetFullInfo());
            }
        }
    }
}
