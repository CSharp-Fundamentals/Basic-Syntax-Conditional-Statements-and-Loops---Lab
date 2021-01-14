using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticket = 0;


            if (age >= 0 && age <= 18)
            {

                switch (typeOfDay)
                {
                    case "Weekday":
                        ticket = 12;
                        break;
                    case "Weekend":
                        ticket = 15;
                        break;
                    case "Holiday":
                        ticket = 5;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;


                }
                Console.WriteLine($"{ticket}$");
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticket = 18;
                        break;
                    case "Weekend":
                        ticket = 20;
                        break;
                    case "Holiday":
                        ticket = 12;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
                Console.WriteLine($"{ticket}$");
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticket = 12;
                        break;
                    case "Weekend":
                        ticket = 15;
                        break;
                    case "Holiday":
                        ticket = 10;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
                Console.WriteLine($"{ticket}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
