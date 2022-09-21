using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string month = Console.ReadLine();
            int accomodations = int.Parse(Console.ReadLine());

            double priceStudioNight = 0;
            double priceApartmentNight = 0;

            switch(month)
            {
                case "May":
                case "October":
                    priceStudioNight = 50.00;
                    priceApartmentNight = 65.00;
                    break;
                case "June":
                case "September":
                    priceStudioNight = 75.20;
                    priceApartmentNight = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudioNight = 76.00;
                    priceApartmentNight = 77.00;
                    break ;

            }
            if (accomodations > 14)
            {
                priceApartmentNight -= priceApartmentNight * 0.10;

                if (accomodations > 14 && (month == "May" || month == "October"))
                {
                    priceStudioNight -= priceStudioNight * 0.30;
                    Console.WriteLine($"Apartment: {(accomodations * priceApartmentNight):f2} lv.");
                    Console.WriteLine($"Studio: {(accomodations * priceStudioNight):f2} lv.");
                }
                else if (month == "June" || month == "September")
                {
                    priceStudioNight -= priceStudioNight * 0.20;
                    Console.WriteLine($"Apartment: {(accomodations * priceApartmentNight):f2} lv.");
                    Console.WriteLine($"Studio: {(accomodations * priceStudioNight):f2} lv.");
                }
                else //month==Juli && August
                {
                    Console.WriteLine($"Apartment: {(accomodations * priceApartmentNight):f2} lv.");
                    Console.WriteLine($"Studio: {(accomodations * priceStudioNight):f2} lv.");
                }
            }
            else if ((accomodations > 7 && accomodations <= 14) && (month == "May" || month == "October"))
            {
                priceStudioNight -= priceStudioNight * 0.05;
                Console.WriteLine($"Apartment: {(accomodations * priceApartmentNight):f2} lv.");
                Console.WriteLine($"Studio: {(accomodations * priceStudioNight):f2} lv.");
            }
            else //accomod<=7 && month== June || Jule || August || September
            {
                Console.WriteLine($"Apartment: {(accomodations * priceApartmentNight):f2} lv.");
                Console.WriteLine($"Studio: {(accomodations * priceStudioNight):f2} lv.");
            }
        }
    }
}
