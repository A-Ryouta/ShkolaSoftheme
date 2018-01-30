namespace UserAuthentication
{
    public interface IAuthenticator
    {
        bool AuthenticateUser(IUser user);
    }
}
