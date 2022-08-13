using System;

namespace ПЗ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число.");
            int inputNumber;
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
            }

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine($"Число {inputNumber} является четным.");
            }
            else Console.WriteLine($"Число {inputNumber} является нечетным.");

            Console.WriteLine("\nДля того, чтобы завершить, нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
