﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument
{
    class Violin : MusInstrument
    {
        public Violin(string typeOfInstrument, string name, double weight, double numberOfOctaves, string sound,
            string history, string describe) :
              base(typeOfInstrument, name, weight, numberOfOctaves, sound, history, describe)
        {
        }
    }
}
