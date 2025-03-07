using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces;

class MyArray : IOutput
{
    public int[] Numbers { get; set; }

    public MyArray(params int[] numbers)
    {
        Numbers = numbers;
    }
    public void Show()
    {
        if (Numbers.Length == 0)
        {
            Console.WriteLine("Array is empty");
            return;
        }
        Console.WriteLine($"All elements of the array: ");
        foreach (int el in Numbers)
        {
            Console.WriteLine(el);
        }
    }
    public void Show(string info)
    {
        MyArray myArray = new MyArray(this.Numbers);
        myArray.Show();
        Console.WriteLine(info);
    }
}
