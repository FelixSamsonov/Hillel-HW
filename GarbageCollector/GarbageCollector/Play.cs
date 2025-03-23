using GarbageCollector.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector;

class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Genre Genre { get; set; }
    public short yearOfProduction;


public Play(string title, string author, Genre genre, short yearOfProduction)
    {
        Title = title;
        Author = author;
        Genre = genre;
        YearOfProduction = yearOfProduction;
    }
    public short YearOfProduction
    {
        get { return yearOfProduction; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Incorrect value");
            else
                yearOfProduction = value;
        }
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"The Play is created: Author: {Author}, Title: {Title}, Genre: {Genre}, Year of production: {YearOfProduction}");
    }
    public void Dispose()
    {
        Console.WriteLine("Information disposed");
    }
    ~Play()
    {
        Console.WriteLine("Play is finalized");
    }
}