using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public class Owner : User, IUser
    {
        List<Horse> horses;

        public Owner(string username, string password, string email) : base(username, password, email)
        {
            horses = new List<Horse>();
        }

        public List<Horse> Horses { get => horses; set => horses = value; }

        public override string ToString()
        {
            return base.ToString() + $"horses: {horses}" + "}";
        }

        public string viewProfile()
        {
            string text = "userID: " + base.UserID + "\n";
            text += "username:" + base.Username + "\n";
            text += "email: " + base.Email + "\n";
            text += "horses: " + string.Join(", ", horses) + "\n";
            return text;
        }
    }
}
