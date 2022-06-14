using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double money = 0;
            for (int i = 1; i <=lostGameCount; i++)
            {
                if (i % 12 == 0)
                {
                    money += displayPrice;
                }
                if (i % 6 == 0)
                {
                    money += keyboardPrice;
                }
                if (i % 3 == 0)
                {
                    money += mousePrice;
                }
                if (i % 2 == 0)
                {
                    money += headSetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {money:f2} lv.");
           
        }
    }
}
