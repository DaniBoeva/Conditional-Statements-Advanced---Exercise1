using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            if (type== "Premiere")
            {
                double profit = rows * columns * 12.00;
                Console.WriteLine($"{profit:f2} leva");
            }
            else if (type== "Normal")
            {
                double profit = rows * columns * 7.50;
                Console.WriteLine($"{profit:f2} leva");
            }
            else
            {
                double profit = rows * columns * 5.00;
                Console.WriteLine($"{profit:f2} leva");
            }
        }
    }
}
