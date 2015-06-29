﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class State
    {
        public string Captial { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public State(string capital, int pop, int size)
        {
            Captial = capital;
            Population = pop;
            Size = size;
        }

        public static Dictionary<string, State> GetStates()
        {
            var states = new Dictionary<string, State>();
            var theState = new State("Montgomery", 123456, 123);
            states.Add("Alabama", theState);
            theState = new State("Juneau", 345234, 3234);
            states.Add("Alaska", theState);
            return states;
        }
    }
}
