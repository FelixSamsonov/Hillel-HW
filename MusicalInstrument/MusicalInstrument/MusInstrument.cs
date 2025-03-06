using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MusicalInstrument;

class MusInstrument
{

    public string? TypeOfInstrument { get; set; }
    private string name;
    private double weight; 
    private double numberOfOctaves;
    public string PlaySound { get; set; }
    public string InstrumentHistory { get; set; }
    public string Describe { get; set; }

    public MusInstrument(string typeOfInstrument, string name, double weight, double numberOfOctaves, 
        string sound, string history, string describe)
    {

        TypeOfInstrument = typeOfInstrument;
        this.name = name;
        this.weight = weight;
        this.numberOfOctaves = numberOfOctaves;
        PlaySound = sound;
        InstrumentHistory = history;
        Describe = describe;
    }

    public string Name
    {
        get { return name; }
        set { name = value.ToLower(); }
  
    }
    public double Weight
    {
        get {return weight; }
        set
        {
            if (Name == "organ" && value < 150000)
                weight = value;
            else if (Name == "concert grand piano" && value < 550)
                weight = value;
            else if (value < 100)
                weight = value;
            else
                Console.WriteLine("Instrument cannot be more than 100 kg");
        }
    }
    public double NumberOfOctaves
    {
        get { return numberOfOctaves; }
        set
        {
            if (value <= 10)
                numberOfOctaves = value;
            else
                Console.WriteLine("Instrument cannot has more than 10 octaves");
        }
    }
        
    public void Sound()
    {
        Console.WriteLine($"The {name} makes sound: {PlaySound} ");
    }
    public void Show()
    {
        Console.WriteLine(name);
    }
    public void Desc()
    {
        Console.WriteLine($"The {name} is {Describe}");
    }
    public void History()
    {
        Console.WriteLine($"The {name} {InstrumentHistory}");
    }
}
