using System;

namespace SummNambers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 101;
            int multipleNumber1 = 3;
            int multipleNumber2 = 5;
            int number = random.Next(minValue, maxValue);
            int sum = 0;

            Console.WriteLine($"Случайное число : {number}");

            for (int i = 0; i <= number; i++)
            {
                if (i % multipleNumber1 == 0 || i % multipleNumber2 == 0)
                {
                    sum += i;
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine($"\nСумма всех чисел которые кратные 3 или 5 = {sum}");
        }
    }
}
