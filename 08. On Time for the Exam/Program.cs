using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            //преобразуваме часовете за изпита в мин и ги събираме
            minuteExam = minuteExam+hourExam*60;
            //преобразуваме часовете на пристигане в мин и ги събираме
            minuteArrive = minuteArrive+hourArrive*60;

            int difference = minuteExam - minuteArrive; // difference>0 ---> ако е дошъл перди началото на изпита
            if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (difference>30) 
            {
                Console.WriteLine("Early");
                if (difference<60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else //differense >=60
                {
                    int diffHours = difference/60;
                    int diffMin = difference%60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours before the start");
                }
            }
            else // difference<0 ---> Late
            {
                Console.WriteLine("Late");
                difference = Math.Abs(difference);
                if (difference<60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else //difference>=60
                {
                    int diffHours = difference / 60;
                    int diffMin = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours after the start");
                }

            }


        }
    }
}
