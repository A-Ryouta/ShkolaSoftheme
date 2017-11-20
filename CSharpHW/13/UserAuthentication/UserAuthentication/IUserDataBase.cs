using System;
using System.Collections.Generic;

namespace UserAuthentication
{
    interface IUserDataBase : IDisposable
    {
        void Add(IUser user);
        bool Find(string userName);
        List<IUser> GetAll();
    }
}
