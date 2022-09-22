using System;

namespace _03vacation
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePer = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    pricePer = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePer = 9.80;
                }
                else if (day == "Sunday")
                    pricePer = 10.46;
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                    pricePer = 10.90;
                else if (day == "Saturday")
                    pricePer = 15.60;
                else if (day == "Sunday")
                    pricePer = 16;
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                    pricePer = 15;
                else if (day == "Saturday")
                    pricePer = 20;
                else if (day == "Sunday")
                    pricePer = 22.50;


            }
            if (type == "Business" && people >= 100)
            {
                people = people - 10;
            }
            double price = people * pricePer;
            if (type == "Students" && people >= 30)
            {
                price = price - (0.15 * price);
            }
            if ( type == "Regular" && people >=10 && people <= 20)
            {
                price = price - (0.05 * price);
            }
            Console.WriteLine($"Total price: {price:F2}");
        }   
    }

}
