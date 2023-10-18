using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public abstract class User
    {
        private int userID;
        private static int countID;
        private string username;
        private string password;
        private string email;

        protected int UserID { get => userID; set => userID = value; }
        protected static int CountID { get => countID; set => countID = value; }
        protected string Username { get => username; set => username = value; }
        protected string Password { get => password; set => password = value; }
        protected string Email { get => email; set => email = value; }

        public User(string username, string password, string email)
        {
            this.userID = countID++;
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public User() { }

        public override string ToString()
        {
            return "{" + $"userID: {userID}, username: {username}, password: {password}, email: {email}";
        }
    }
}
