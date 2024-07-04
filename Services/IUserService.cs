namespace PWAblazorLoginAndRegister.Services
{
    public interface IUserService
    {
        string Username { get; }
        void SetUsername(string username);
    }
}
