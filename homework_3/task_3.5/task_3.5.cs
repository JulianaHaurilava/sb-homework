using System;

namespace task_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру угадайку!\n" +
                              "Введите максимальное целое число диапазона.");
            int maxValue;
            while (!int.TryParse(Console.ReadLine(), out maxValue))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
            }
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(maxValue + 1);

            while (true)
            {
                Console.WriteLine($"Введите целое число от 0 до {maxValue} включительно.\n" +
                                   "Для того, чтобы выйти, введите пустую строку.");
                string userInput = Console.ReadLine();

                if (userInput == " ")
                {
                    Console.WriteLine($"Было загадано число {randomNumber}");
                    break;
                }
                int userNumber;
                while (!int.TryParse(userInput, out userNumber))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число.");
                    userInput = Console.ReadLine();
                }
                if (userNumber > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше.\n");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше.\n");
                }
                else
                {
                    Console.WriteLine("Число отгадано!");
                    break;
                }
            }

            Console.WriteLine("\nДля того, чтобы завершить, нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
