﻿using System;

namespace _10multiplication
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int times = 1;
            while (times <= 10)
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
                times++;
            }

        }
    }
}
