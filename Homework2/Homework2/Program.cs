using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            int result;

            Console.WriteLine("Please enter the operation: ");
            operand = Console.ReadLine();

            Console.WriteLine("Please enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();


        }
    }
    
}
