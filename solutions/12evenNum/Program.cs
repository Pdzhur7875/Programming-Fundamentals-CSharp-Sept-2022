using System;

namespace _12evenNum
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int n = Math.Abs(num);
            if (n % 2 != 0)
            {
                while (n % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());
                    n = Math.Abs(num);
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"The number is: {n}");
                        return;
                    }   
                }
            }
            else
            {
                Console.WriteLine($"The number is: {n}");
            }
        }
    }
}
