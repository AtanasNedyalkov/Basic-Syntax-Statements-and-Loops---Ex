using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double n = double.Parse(Console.ReadLine());
            double nCopy = n;
            double factoriel = 1;
            while (n <= 0)
            {
               double number = n % 10;
                number /= 10;
                factoriel += n * number;
                n--;
            }
            if (factoriel == nCopy)
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
