using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input!="Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 ||
                    coins == 0.2 ||
                    coins == 0.5 ||
                    coins == 1.0 ||
                    coins == 2.0 ) 
                {
                    balance += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            double productPrice = 0;
            while (input!="End")
            {
                switch (input)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;

                }
                if (balance>=productPrice && productPrice>0)
                {
                    string productToLower = input.ToLower();
                    Console.WriteLine($"Purchased {productToLower}");
                    balance -= productPrice;
                }
                else if (productPrice>0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
