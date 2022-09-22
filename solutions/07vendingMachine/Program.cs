using System;

namespace _07vendingMachine
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double sumCoins = 0;
            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumCoins += coins;
                }
                else { Console.WriteLine($"Cannot accept {coins}"); }
                command = Console.ReadLine();
            }

            if (command == "Start")
            {
                string product = Console.ReadLine();
                while (product != "End")
                {

                    if (sumCoins <= 0) { Console.WriteLine("Not enough money"); }
                    else { 
                    switch (product)
                    {
                        //· "Nuts" with a price of 2.0

                        //· "Water" with a price of 0.7

                        //· "Crisps" with a price of 1.5

                        //· "Soda" with a price of 0.8

                        //· "Coke" with a price of 1.0
                        case "Nuts":
                            sumCoins -= 2;
                            break;
                        case "Water":
                            sumCoins -= 0.7;
                            break;
                        case "Crisps":
                            sumCoins -= 1.5;
                            break;
                        case "Soda":
                            sumCoins -= 0.8;
                            break;
                        case "Coke":
                            sumCoins -= 1.0;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                    }
                    product = Console.ReadLine();
                }
                
            }
        }
    }
}