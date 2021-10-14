using System;
using System.Text.RegularExpressions;

namespace Bussines
{
    public class RegisterUser : IRegisterUser
    {        
        public bool Register(string email, string password, string password2)
        {
            var checkemail = new Regex("^(\\w+)@(\\w+).(\\w+)$", RegexOptions.Compiled);
            if(!checkemail.IsMatch(email))
            {
                return false;
            }

            if(password.Length<10)
            {
                return false;
            }
            if (password != password2) { return false; }

            return true;
        }
    }
}
