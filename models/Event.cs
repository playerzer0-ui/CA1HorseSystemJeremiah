using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public class Event
    {
        private int eventID;
        private static int countID = 1;
        private List<Race> races;
        private string eventName;
        private string location;


        public Event(string eventName, string location)
        {
            eventID = countID++;
            races = new List<Race>();
            this.eventName = eventName;
            this.location = location;
        }

        public Event()
        {
            eventID = countID++;
        }
        public int EventID { get => eventID; set => eventID = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string Location { get => location; set => location = value; }
        public List<Race> Races { get => races; set => races = value; }

        public override bool Equals(object? obj)
        {
            return obj is Event @event &&
                   eventID == @event.eventID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(eventID);
        }

        public override string ToString()
        {
            return "{" + $"eventID: {eventID}, name: {eventName}, location: {location}" + "}";
        }
    }
}
