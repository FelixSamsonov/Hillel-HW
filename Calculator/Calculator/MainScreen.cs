using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp;

class MainScreen
{
    public void ShowScreen()
    {
        Console.WriteLine("Welcome to the Calculator");
        Console.WriteLine("Enter your equation, and I'll calculate it for you!");
        string? inputData = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(inputData))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        char[] data = inputData.ToArray();
        string inputFirstNumber = "";
        char inputOperation = '\0';
        string inputSecondNumber = "";
        bool foundOperator = false;

        foreach (char op in data)
        {
            if ((op == '+' || op == '-' || op == '*' || op == '/') && inputFirstNumber != "" && !foundOperator)
            {
                inputOperation = op;
                foundOperator = true;
            }
            else
            {
                if (!foundOperator || (foundOperator && inputSecondNumber == "" && op == '-'))
                    inputFirstNumber += op;
                else
                    inputSecondNumber += op;
            }
        }
        if (decimal.TryParse(inputFirstNumber, out decimal firstNumber))
        {
            if (decimal.TryParse(inputSecondNumber, out decimal secondNumber))
            {
                CalculationData c = new CalculationData(firstNumber, inputOperation, secondNumber);
                c.Calculate();
            }
            else
                Console.WriteLine("Error: second value not a number!");
        }
        else
            Console.WriteLine("Error: first value not a number!");

    }
}
