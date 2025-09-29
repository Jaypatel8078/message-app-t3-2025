using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 0d;
            var secondNumber = 0d;
            var type = ' ';
            var result = 0d;
            var response = true;
            var responseInput = "";

            while (response)
            {
                Console.WriteLine("Enter first number:");
                firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter calculation operator: (+, -, * or /)");
                type = char.Parse(Console.ReadLine());
                result = CalculateResult(firstNumber, secondNumber, type);
                Console.WriteLine("Your calculation reads as follows: {0} {1} {2} = {3}", firstNumber, type, secondNumber, result);
                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                responseInput = Console.ReadLine();
                if (responseInput == "n")
                    response = false;
            }

        }

        static private double CalculateResult(double number1, double number2, char ctype)
        {
            var result = 0d;

            switch (ctype)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    result = -10000;
                    break;
            }
            return result;
        }
    }
}
