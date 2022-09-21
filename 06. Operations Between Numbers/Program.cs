using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int numberOne = int.Parse(Console.ReadLine());
            double numberTwo = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = numberOne+numberTwo;
                    break;
                case "-":
                    result = numberOne-numberTwo;
                    break ;
                case "*":
                    result = numberOne*numberTwo;
                    break;
                case "/":
                    result = numberOne/numberTwo;
                    break;
                case "%":
                    result = numberOne%numberTwo;
                    break;

            }
            if ((operation=="+" || operation=="-" || operation=="*") && result%2==0)
            {
                Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - even");
            }
            else if ((operation == "+" || operation == "-" || operation == "*") && result % 2 != 0)
            {
                Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - odd");
            }
            else if (operation=="/" && numberTwo==0)
            {
                Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
            else if(operation=="/" && numberTwo!=0)
            {
                Console.WriteLine($"{numberOne} / {numberTwo} = {(result):f2}");
            }
            else if (operation=="%" && numberTwo==0)
            {
                Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
            else if(operation == "%" && numberTwo!=0)
            {
                Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
            }
        }
    }
}
