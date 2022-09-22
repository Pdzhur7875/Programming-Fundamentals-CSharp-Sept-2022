using System;

namespace _05logIn
{
    internal class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char userCh = username[i];
                password += userCh;
            }
            string enteredPassword;
            int passwordTries = 0;
            while(( enteredPassword = Console.ReadLine()) != password)
            {
                passwordTries++;
                if (passwordTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
