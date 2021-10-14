namespace Bussines
{
    public interface IRegisterUser
    {
        bool Register(string email, string password, string password2);
    }
}