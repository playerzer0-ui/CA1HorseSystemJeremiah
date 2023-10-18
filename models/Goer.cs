using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public class Goer : User, IUser
    {
        public Goer()
        {
            
        }

        public Goer(string username, string password, string email) : base(username, password, email)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "}";
        }

        public string viewProfile()
        {
            string text = "userID: " + base.UserID + "\n";
            text += "username:" + base.Username + "\n";
            text += "email: " + base.Email + "\n";
            return text;
        }
    }
}
