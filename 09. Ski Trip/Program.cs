using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int day = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;

            switch(room)
            {
                case "room for one person":
                    price = (day-1)*18.00;
                    break;
                case "apartment":
                    price = (day - 1) * 25;
                    break;
                case "president apartment":
                    price = (day - 1) * 35;
                    break;
            }
            if (room == "apartment" && day < 10)
            {
                if (rating == "positive")
                {
                    price = (price - (price * 0.30)) + ((price - (price * 0.30)) * 0.25);
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price = (price - (price * 0.30)) - ((price - (price * 0.30)) * 0.10);
                    Console.WriteLine($"{price:f2}");
                }

            }
            else if (room == "apartment" && day > 15)
            {
                if (rating == "positive")
                {
                    price = (price - (price * 0.35)) + ((price - (price * 0.35)) * 0.25);
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price = (price - (price * 0.50)) - ((price - (price * 0.50)) * 0.10);
                    Console.WriteLine($"{price:f2}");
                }
            }
            else if (room == "apartment" && day >= 10 && day <= 15) //day=14 price=25
            {
                if (rating == "positive")
                {
                    price = (price - (price * 0.35))+((price - (price * 0.35)) * 0.25); // =14
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price = (price - (price * 0.35)) - ((price - (price * 0.35)) * 0.10); //
                    Console.WriteLine($"{price:f2}");
                }
            }
            else if (room == "president apartment" && day < 10)
            {
                if (rating == "positive")
                {
                    price = (price - (price * 0.10)) + ((price - (price * 0.10)) * 0.25);
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price = (price - (price * 0.10)) - ((price - (price * 0.10)) * 0.10);
                    Console.WriteLine($"{price:f2}");
                }
            }
            else if (room == "president apartment" && day > 15)
            {
                if (rating == "positive")
                {
                    price = (price - (price * 0.20)) + ((price - (price * 0.20)) * 0.25);
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price = (price - (price * 0.20)) - ((price - (price * 0.20)) * 0.10);
                    Console.WriteLine($"{price:f2}");
                }
            }
            else if (room == "president apartment" && day >= 10 && day <= 15)
            {
                if (rating == "positive")
                {
                    price = (price - (price * 0.15)) + ((price - (price * 0.15)) * 0.25);
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price = (price - (price * 0.15)) - ((price - (price * 0.15)) * 0.10);
                    Console.WriteLine($"{price:f2}");
                }
            }
            else if (room == "room for one person")
            {
                if (rating == "positive")
                {
                    price += price * 0.25;
                    Console.WriteLine($"{price:f2}");
                }
                else //raiting==negative
                {
                    price -= price * 0.10;
                    Console.WriteLine($"{price:f2}");
                }
            }
        }
    }
}
