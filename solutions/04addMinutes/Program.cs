using System;

namespace _04addMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int mins = minutes + 30;
            if( mins >= 60)
            {
                hours += 1;
                mins = mins - 60;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
            }
            Console.WriteLine($"{hours}:{mins:D2}");
        }
    }
}
