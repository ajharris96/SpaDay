using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        
        public User()
        {
            Created = DateTime.Now;
        }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        public bool VerifyPassword(string verify)
        {
            return Password == verify;
        }
    }
}
