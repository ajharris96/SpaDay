using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Created { get; }
        public DateTime dateTime = DateTime.Now;

        public User()
        {
        }

        public User(string username, string email, string password, DateTime dateTime)
        {
            Username = username;
            Email = email;
            Password = password;
            Created = dateTime;
        }

        public bool VerifyPassword(string verify)
        {
            return Password == verify;
        }
    }
}
