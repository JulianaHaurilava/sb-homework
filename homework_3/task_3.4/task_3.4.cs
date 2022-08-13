using System;

namespace task_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности.");
            int inputLength;
            while (!int.TryParse(Console.ReadLine(), out inputLength))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
            }
            int minNumber = int.MaxValue;

            for (int i = 0; i < inputLength; i++)
            {
                Console.Write("Введите число: ");
                int inputNumber;
                while (!int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число.");
                }
                minNumber = Math.Min(inputNumber, minNumber);
            }
            Console.WriteLine($"Минимальное число последовательности: {minNumber}");

            Console.WriteLine("\nДля того, чтобы завершить, нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
