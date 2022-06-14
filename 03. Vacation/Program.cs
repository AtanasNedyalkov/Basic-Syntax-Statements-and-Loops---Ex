using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroupe = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double sum = 0;
            if (dayOfWeek == "Friday")
            {
                if (typeOfGroupe=="Students")
                {
                    sum +=countOfPeople* 8.45;
                    if (countOfPeople>=30)
                    {
                        sum = sum - sum * 0.15;
                    }
                }
                else if (typeOfGroupe=="Business")
                {
                    sum += countOfPeople* 10.90;
                    if (countOfPeople >= 100)
                    {
                        sum = sum - 10*10.90;
                    }
                }
                else if (typeOfGroupe=="Regular")
                {
                    sum += countOfPeople * 15;
                    if (countOfPeople >= 10 && countOfPeople<= 20)
                    {
                        sum = sum - sum*0.05;
                    }
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroupe == "Students")
                {
                    sum += countOfPeople * 9.80;
                    if (countOfPeople >= 30)
                    {
                        sum = sum - sum * 0.15;
                    }
                }
                else if (typeOfGroupe == "Business")
                {
                    sum += countOfPeople * 15.60;
                    if (countOfPeople >= 100)
                    {
                        sum = sum - 10 * 15.60;
                    }
                }
                else if (typeOfGroupe == "Regular")
                {
                    sum += countOfPeople * 20;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        sum = sum - sum * 0.05;
                    }
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroupe == "Students")
                {
                    sum += countOfPeople * 10.46;
                    if (countOfPeople >= 30)
                    {
                        sum = sum - sum * 0.15;
                    }
                }
                else if (typeOfGroupe == "Business")
                {
                    sum += countOfPeople * 16;
                    if (countOfPeople >= 100)
                    {
                        sum = sum - 10 * 16;
                    }
                }
                else if (typeOfGroupe == "Regular")
                {
                    sum += countOfPeople * 22.50;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        sum = sum - sum * 0.05;
                    }
                }
            }
                Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
