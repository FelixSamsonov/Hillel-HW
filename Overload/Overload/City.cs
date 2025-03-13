using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload;

class City
{
    private float numberOfCityzens;
    private int area;
    public string Name { get; set; }
    private short yearOfFoundation;
    public int OutOfTownStudents { get; set; } = 17635;
    public int VacantionPeople { get { return (int)NumberOfCityzens * 25 / 100; } }
    public static City operator ++(City population)
    {
        return new City(population.NumberOfCityzens + population.OutOfTownStudents, population.Area, 
            population.Name, population.YearOfFundation);
    }
    public static City operator --(City population)
    {
        return new City(population.NumberOfCityzens - population.OutOfTownStudents, population.Area,
            population.Name, population.YearOfFundation);
    }
    public static bool operator ==(City city1, City city2)
    { return city1.NumberOfCityzens ==  city2.NumberOfCityzens; }
    public static bool operator !=(City city1, City city2)
    { return city1.NumberOfCityzens == city2.NumberOfCityzens; }
    public static bool operator >(City city1, City city2)
    { return city1.NumberOfCityzens >  city2.NumberOfCityzens; }
    public static bool operator <(City city1, City city2)
    { return city1.NumberOfCityzens < city2.NumberOfCityzens; }


    public City(float numberOfCityzens, int area, string name, short fundationYear)
    {
        this.numberOfCityzens = numberOfCityzens;
        this.area = area;
        Name = name;
        this.yearOfFoundation = fundationYear;
        
    }
    public float NumberOfCityzens
    {
        get { return numberOfCityzens; }
        set
        {
            if (value <= 10000)
                throw new Exception("The settlement is not a city. City has to have more than 10000 cityzens");
            else
                numberOfCityzens = value;
        }
    }
    public int Area
    {
        get { return area; }
        set
        {
            if (value < 5)
                throw new Exception("The settlement is not a city. City has to have more than 5 square kilometers");
            else
                area = value;
        }
    }
    public short YearOfFundation
    {
        get { return yearOfFoundation; }
        set
        {
            if (value <= 0)
                throw new Exception("City cannot be foundation in 0 and less year");
            else
                yearOfFoundation = value;
        }
    }
    
}


