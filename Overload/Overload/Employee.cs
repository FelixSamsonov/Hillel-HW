using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload;

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Position { get; set; }
    private double salary;
    private byte workExperience;
    public double Taxes { get { return Salary * 0.2; }}

    public static Employee operator ++(Employee employee)
    {
        return new Employee(employee.Name, employee.Surname, employee.Position,
                        employee.Salary + employee.BonusCoefficient, employee.WorkExperience);
    }
    public static Employee operator --(Employee employee)
    {
        return new Employee(employee.Name, employee.Surname, employee.Position,
                        employee.Salary - employee.Taxes, employee.WorkExperience);
    }
   public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Salary == employee2.Salary;
    }
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Salary == employee2.Salary;
    }
    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.Salary > employee2.Salary;
    }
    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.Salary < employee2.Salary;
    }

    public Employee(string name, string surname, string position, double salary, byte experience)
    {
        Name = name;
        Surname = surname;
        Position = position;
        Salary = salary;
        WorkExperience = experience;
        
    }
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 500)
                throw new Exception("Employee cannot earn less than 500");
            else
                salary = value;
        }
    }
    public byte WorkExperience
    {
        get { return workExperience; }
        set
        {
            if (value > 0)
                workExperience = value;
            else
                throw new Exception("Experience cannot be less than 0 year!");

        }
    }
    public double BonusCoefficient
    {
        get
        {
            if (WorkExperience > 0 && WorkExperience <= 3)
                return 1000;
            else if (WorkExperience > 3 && WorkExperience <= 5)
                return 1500;
            else if (WorkExperience > 5 && WorkExperience <= 10)
                return 2500;
            else if (WorkExperience > 10 && WorkExperience <= 15)
                return 5000;
            else if (WorkExperience > 15 && WorkExperience <= 20)
                return 7500;
            else if (WorkExperience > 20)
               return 10000;
            else
                throw new ArgumentException("Incorrect value");
        }
    }
}
    


