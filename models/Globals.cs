﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1HorseSystemJeremiah.models
{
    public enum UserType
    {
        Manager,
        Owner,
        Goer
    }
    public class Globals
    {
        public static List<Event> events = new List<Event>();
    }
}
