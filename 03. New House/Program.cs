using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string flowers = Console.ReadLine();
            int numbersOfFlowers = int.Parse(Console.ReadLine());
            int boujet = int.Parse(Console.ReadLine());
            

            if (flowers=="Roses")
            {
                if (numbersOfFlowers>80)
                {
                    double price = (numbersOfFlowers * 5.00);
                    double discount = price * 0.10;
                    double difference = boujet -(price - discount);
                    if (difference>=0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }

                }
                else //numberOfFlowers<=80
                {
                    double price = numbersOfFlowers * 5.00;
                    double difference = boujet - price;
                    if (difference>=0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else //difference<0
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
            }
            else if (flowers== "Dahlias")
            {
                if (numbersOfFlowers>90)
                {
                    double price = (numbersOfFlowers * 3.80);
                    double discount = price * 0.15;
                    double difference = boujet - (price - discount);
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
                else
                {
                    double price = numbersOfFlowers * 3.80;
                    double difference = boujet - price;
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else //difference<0
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
            }
            else if (flowers== "Tulips")
            {
                if (numbersOfFlowers > 80)
                {
                    double price = (numbersOfFlowers * 2.80);
                    double discount = price * 0.15;
                    double difference = boujet - (price - discount);
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }

                }
                else //numberOfFlowers<=80
                {
                    double price = numbersOfFlowers * 2.80;
                    double difference = boujet - price;
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else //difference<0
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
            }
            else if (flowers== "Narcissus")
            {
                if (numbersOfFlowers<120)
                {
                    double price = (numbersOfFlowers * 3.00);
                    double markup = price * 0.15;
                    double difference = boujet - (price +markup);
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
                else
                {
                    double price = numbersOfFlowers * 3.00;
                    double difference = boujet - price;
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else //difference<0
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
            }
            else if (flowers== "Gladiolus")
            {
                if (numbersOfFlowers < 80)
                {
                    double price = (numbersOfFlowers * 2.50);
                    double markup = price * 0.20;
                    double difference = boujet - (price + markup);
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
                else
                {
                    double price = numbersOfFlowers * 2.50;
                    double difference = boujet - price;
                    if (difference >= 0)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbersOfFlowers} {flowers} and {(difference):f2} leva left.");
                    }
                    else //difference<0
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
                    }
                }
            }
        }
    }
}
