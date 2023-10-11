using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public class Race
    {
        private int raceID;
        private static int countID = 1;
        private string name;
        private int hours;
        private int minutes;
        private List<Horse> horses = new List<Horse>();

        public Race(string name, int hours, int minutes)
        {
            raceID = countID++;
            this.name = name;
            this.hours = hours;
            this.minutes = minutes;
        }

        public Race(int hours, int minutes)
        {
            raceID = countID++;
            name = "race" + countID;
            this.hours = hours;
            this.minutes = minutes;
        }

        public Race() { raceID = countID++; }

        public int RaceID { get => raceID; set => raceID = value; }
        public static int CountID { get => countID; set => countID = value; }
        public string Name { get => name; set => name = value; }
        public List<Horse> Horses { get => horses; set => horses = value; }
        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }

        public override bool Equals(object? obj)
        {
            return obj is Race race &&
                   raceID == race.raceID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(raceID);
        }

        public override string ToString()
        {
            string time = "";
            if(hours < 10)
            {
                time += "0" + hours + ":";
            }
            else
            {
                time += hours + ":";
            }
            if(minutes < 10)
            {
                time += "0" + minutes;
            }
            else
            {
                time += minutes;
            }
            return "{" + $"raceID: {raceID}, raceName: {name}, startTime: {time}" + "}";
        }
    }
}
