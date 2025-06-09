using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp;

public class CalculationData
{
    public decimal FirstNumber { get; set; }
    private char operation;
    public decimal SecondNumber { get; set; }

    public CalculationData(decimal firstNumber, char operation, decimal secondNumber)
    {
        FirstNumber = firstNumber;
        this.operation = operation;
        SecondNumber = secondNumber;
    }

    public char Operation
    {
        get { return operation; }
        set
        {
            if (value == '+' || value == '-' || value == '*' || value == '/')
                operation = value;
            else
                throw new ArgumentException("You used incorect operation");
        }
    }

    public void Calculate()
    {
        switch (operation)
        {
            case '+':
                Console.Write($"Your result: {FirstNumber + SecondNumber}");
                break;
            case '-':
                Console.Write($"Your result: {FirstNumber - SecondNumber}");
                break;
            case '*':
                Console.Write($"Your result: {FirstNumber * SecondNumber}");
                break;
            case '/':
                if (SecondNumber == 0)
                    throw new DivideByZeroException("You cannot divide by zero!!!");
                Console.Write($"Your result: {FirstNumber / SecondNumber}");
                break;
            default: throw new ArgumentException("Invalid operation");
        }
    }
}
