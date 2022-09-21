using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string typeOfVacantion = " ";
            string destination = " ";

            if (budjet<=100)
            {
                if (season== "summer")
                {
                    typeOfVacantion = "Camp";
                    destination = "Bulgaria";
                    price = budjet * 0.30;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfVacantion} - {price:f2}");
                }
                if (season== "winter")
                {
                    typeOfVacantion = "Hotel";
                    destination = "Bulgaria";
                    price = budjet * 0.70;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfVacantion} - {price:f2}");
                }
            }
            else if (budjet>1000)
            {
                typeOfVacantion = "Hotel";
                destination = "Europe";
                price = budjet * 0.90;
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{typeOfVacantion} - {price:f2}");
            }
            else
            {
                if (season == "summer")
                {
                    typeOfVacantion = "Camp";
                    destination = "Balkans";
                    price = budjet * 0.40;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfVacantion} - {price:f2}");
                }
                if (season == "winter"&&(season== "summer" || season== "winter"))
                {
                    typeOfVacantion = "Hotel";
                    destination = "Balkans";
                    price = budjet * 0.80;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfVacantion} - {price:f2}");
                }
            }
        }
    }
}
