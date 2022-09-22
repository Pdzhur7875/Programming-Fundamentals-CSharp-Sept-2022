using System;

namespace _06strongNumber
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            int factorialSum = 0;
            while (numCopy > 0)
            {
                int lastdigit = numCopy % 10;
                numCopy /= 10;
                int factorial = 1;
                for (int i = 1; i <= lastdigit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        
    }
}
