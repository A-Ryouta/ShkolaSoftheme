using System;

namespace UserAuthentication
{
    public interface IAuthenticationDate
    {
        DateTime LastAuthentication { get; set; }
    }
}
