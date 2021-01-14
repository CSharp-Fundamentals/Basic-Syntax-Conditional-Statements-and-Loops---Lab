using System;

namespace BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesPlusThirty = minutes + 30;

            if (hours >= 0 && hours < 24 && minutesPlusThirty >= 60)
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;
                }
                minutes = (minutesPlusThirty) % 60;
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}".ToString().PadLeft(2, '0'));
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes}".ToString().PadLeft(2, '0'));
                }
            }
            else
            {
                minutes = (minutesPlusThirty) % 60;
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}".ToString().PadLeft(2, '0'));
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes}".ToString().PadLeft(2, '0'));
                }
            }
        }
    }
}