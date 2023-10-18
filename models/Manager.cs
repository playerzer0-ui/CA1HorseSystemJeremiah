using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public class Manager : User, IUser
    {
        private List<Event> events;

        public Manager(string username, string password, string email) : base(username, password, email)
        {
            events = new List<Event>();
        }

        public List<Event> Events { get => events; set => events = value; }

        public override string ToString()
        {
            return base.ToString() + $"events: {events}" + "}";
        }

        public string viewProfile()
        {
            string text = "userID: " + base.UserID + "\n";
            text += "username:" + base.Username + "\n";
            text += "email: " + base.Email + "\n";
            text += "events: " + string.Join(", ", events) + "\n";
            return text;
        }
    }
}
