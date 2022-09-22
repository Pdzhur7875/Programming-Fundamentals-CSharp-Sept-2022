using System;

namespace _04printAndSum
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = n; i <= (m - 1); i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            sum += m;
            Console.Write(m);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
