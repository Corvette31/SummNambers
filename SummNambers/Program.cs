using System;

namespace SummNambers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int minValue = 0;
            int maxValue = 101;
            int number = rand.Next(minValue, maxValue);
            int summ = 0;

            Console.WriteLine($"Случайное число : {number}");
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine($"\nСумма всех чисел которые кратные 3 или 5 = {summ}");
        }
    }
}
