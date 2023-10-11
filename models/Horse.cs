using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public class Horse
    {
        private int horseID;
        private string horseName;
        private static int countID = 1;
        private DateTime doB;

        public Horse(string horseName, DateTime doB)
        {
            horseID += countID++;
            this.horseName = horseName;
            this.doB = doB;
        }

        public Horse() { horseID += countID++; }

        public int HorseID { get => horseID; set => horseID = value; }
        public string HorseName { get => horseName; set => horseName = value; }
        public DateTime DoB { get => doB; set => doB = value; }
        public static int CountID { get => countID; set => countID = value; }

        public override bool Equals(object? obj)
        {
            return obj is Horse horse &&
                   horseID == horse.horseID &&
                   horseName == horse.horseName &&
                   doB == horse.doB;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(horseID, horseName, doB);
        }

        public override string ToString()
        {
            return $"{{{nameof(HorseID)}={HorseID.ToString()}, {nameof(HorseName)}={HorseName}, {nameof(DoB)}={DoB.ToString()}}}";
        }
    }
}
