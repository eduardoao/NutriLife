using System;

namespace NutriLife.Core.Domain
{
    public class User : Base
    {
        public User()
        {
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;          
        }

        public string Email { get; private set; }
        public string Password { get; private set; }    

        public Guid GetId()
        {
            return Id;
        }
    }
}