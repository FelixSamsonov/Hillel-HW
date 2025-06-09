namespace Overload;
internal class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Din", "Churec", "Manager", 7500, 8);
        employee++;
        Console.WriteLine(employee.Salary);
        employee--;
        Console.WriteLine(employee.Salary);
        Employee emp1 = new Employee("Van", "Chup", "Seller", 5000, 3);
        Employee emp2 = new Employee("Mac", "Sipt", "Seller", 3500, 1);
        bool result1 = emp1 == emp2;
        bool result2 = emp1 > emp2;
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        //City city = new City(305000, 215, "Kherson", 1778);
        //city++;
        //Console.WriteLine(city.NumberOfCityzens);
        //city--;
        //Console.WriteLine(city.NumberOfCityzens);
        //City city1 = new City(500000, 300, "Mykolayv", 1768);
        //City city2 = new City(153500, 153, "Novyi Bug", 1895);
        //bool c = city1 == city2;
        //bool d = city2 < city1;
        //Console.WriteLine(c);
        //Console.WriteLine(d);
        //CreditCard creditCard = new CreditCard("Andryi", "Salan", 63000, 525);
        ////creditCard++;
        ////Console.WriteLine(creditCard.OwnMoney);
        //creditCard--;
        //Console.WriteLine(creditCard.OwnMoney);
        //CreditCard creditCard1 = new CreditCard("Kateryna", "Vovk", 89632, 324);
        //CreditCard creditCard2 = new CreditCard("Nico", "Williams", 115000, 789);
        //bool cResult = creditCard1 == creditCard2;
        //bool cResult2 = creditCard2 > creditCard1;
        //Console.WriteLine(cResult);
        //Console.WriteLine(cResult2);
        //Matrix matrix1 = new Matrix(3, 3);
        //Matrix matrix2 = new Matrix(3, 3);
        //int[,] valuesA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //int[,] valuesB = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        //matrix1.Values = valuesA;
        //matrix2.Values = valuesB;
        //Matrix plus = matrix1 + matrix2;
        //Matrix minus = matrix1 - matrix2;
        //Matrix multiply = matrix1 * matrix2;
        //matrix1++;
        //matrix2++;
        //bool common = matrix1 == matrix2;
        //Console.WriteLine("Матриця A:");
        //matrix1.Show();
        //Console.WriteLine("\nМатриця B:");
        //matrix2.Show();
        //Console.WriteLine();
        //plus.Show();
        //Console.WriteLine();
        //minus.Show();
        //Console.WriteLine();
        //multiply.Show();
        //Console.WriteLine();
        //Console.WriteLine(common);

    }
}