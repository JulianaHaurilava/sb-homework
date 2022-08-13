using System;

namespace task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCards, sum = 0;
            Console.WriteLine("Добро пожаловать! Введите количество ваших карт.");
            while (!int.TryParse(Console.ReadLine(), out numberOfCards))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
            }

            Console.WriteLine("\nУсловные обозначения:\n" +
                              "Валет = J\nДама = Q\nКороль = K\nТуз = T\n");
            for (int i = 0; i < numberOfCards; i++)
            {
                bool inputNotCorrect = true;
                while (inputNotCorrect)
                {
                    Console.Write("Введите номинал следующей карты: ");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                        case "10":
                            {
                                sum += int.Parse(userInput);
                                inputNotCorrect = false;
                                break;
                            }
                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            {
                                sum += 10;
                                inputNotCorrect = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Некорректный ввод! Повторите попытку...");
                                break;
                            }
                    }
                }
            }
            Console.WriteLine($"\nИтого: {sum}");

            Console.WriteLine("\nДля того, чтобы завершить, нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
