using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNumber;

public struct DecimalNumber
{
    public int Number { get; set; }

    public DecimalNumber(int number) { Number = number; }

    public void Binary()
    {
        string binary = Convert.ToString(Number, 2);
        Console.WriteLine($"Your number in binary system is: {binary} ");
    }
    public void Octal()
    {
        string octal = Convert.ToString(Number, 8);
        Console.WriteLine($"Your number in octal system is: {octal} ");
    }
    public void Hex()
    {
        string hex = Convert.ToString(Number, 16).ToUpper();
        Console.WriteLine($"Your number in hexadecimal system is: {hex}");
    }

}
