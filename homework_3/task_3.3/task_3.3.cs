using System;

namespace task_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Введите целое число.");
            int inputNumber, i = 2;
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
            }
            while (i < inputNumber)
            {
                if (inputNumber % i++ == 0)
                {
                    Console.WriteLine($"Число {inputNumber} является составным.");
                    isPrime = false;
                    break;
                }
            }

            if (inputNumber <= 1)
            {
                Console.WriteLine($"Число {inputNumber} не является ни простым, ни составным.");
            }
            else if (isPrime)
            {
                Console.WriteLine($"Число {inputNumber} является простым.");
            }

            Console.WriteLine("\nДля того, чтобы завершить, нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
