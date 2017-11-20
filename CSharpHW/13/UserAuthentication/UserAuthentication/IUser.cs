namespace UserAuthentication
{
    public interface IUser : IAuthenticationDate
    {
        string Name { get; }
        string Password { get; }
        string Email { get; }
        string GetFullInfo();        
    }
}
