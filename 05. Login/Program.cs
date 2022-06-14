using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";
            int attempts = 1;
            for (int i = userName.Length-1; i >= 0; i--)
            {
                password += userName[i];
            }
            string currentPassword = Console.ReadLine();
            while (true)
            {
                if (currentPassword!=password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    attempts++;
                }
                else if (currentPassword ==password)
                {
                    
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                if (attempts  == 4)

                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                currentPassword = Console.ReadLine();
       
            }
            
        }
    }
}
