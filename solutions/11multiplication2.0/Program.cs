using System;

namespace _11multiplication2._0
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times < 11)
            {
                while (times <= 10)
                {
                    Console.WriteLine($"{num} X {times} = {num * times}");
                    times++;
                }
            }
            else
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
            }
        }
    }
}
