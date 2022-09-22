using System;

namespace _09oddNumbersSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddNum = 1;
            while(n > 0)
            {
                Console.WriteLine(oddNum);
                sum += oddNum;
                oddNum += 2;
                n--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
