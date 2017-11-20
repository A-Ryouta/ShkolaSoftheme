namespace UserAuthentication
{
    interface IAuthenticator
    {
        bool AuthenticateUser(IUser user);
    }
}
