using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interfaces;

class MyArray : IOutput, IMath, ISort
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
            Console.Write($"{el} ");
        }
        
    }
    public void Show(string info)
    {
        Console.WriteLine();
        Show();
        Console.Write($"- {info}");
        Console.WriteLine();
    }
    public int Max()
    {
        Console.Write("The max number in array is: ");
        return Numbers.Max();    
    }
    public int Min()
    {
        Console.Write("The min number in array is: ");
        return Numbers.Min();
    }
    public float Avg()
    {
        Console.Write("The average number of array is: ");
        return (float)Numbers.Average();
    }
    public bool Search(int valueToSearch)
    {
        Console.Write($"Is there number {valueToSearch} in array? - ");
        bool found = Numbers.Any(x => x == valueToSearch);
        return found;
    }
    public void SortAsc()
    {
        var sorted = Numbers.Order();
        Console.Write("Sorted by ascending:");
        foreach (var el in sorted)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();
    }

    public void SortDesc()
    {
        var sortDesc = Numbers.OrderByDescending(x => x);
        Console.Write("Sorted by descending:");
        foreach (var el in sortDesc)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();
    }
    public void SortByParam(bool isAsc)
    {
        if (isAsc == true)
            SortAsc();
        else
            SortDesc();
    }


}
