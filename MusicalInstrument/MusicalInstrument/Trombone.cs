﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument;

class Trombone : MusInstrument
{
    public Trombone(string typeOfInstrument, string name, double weight, double numberOfOctaves, string sound,
           string history, string describe) :
             base(typeOfInstrument, name, weight, numberOfOctaves, sound, history, describe)
    {
    }
}
