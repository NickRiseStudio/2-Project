using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");

            Console.Write("Введите диапазон минимального числа: ");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите диапазон максимального числа: ");
            int higher = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество попыток: ");
            int tryesCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Отлично, теперь угадайте число из этого диапазона, у Вас всего " + tryesCount + " попыток");
            Console.Write("Введите число: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();

            for (int i = 1; i < tryesCount; i++)
            {
            int number = rand.Next(lower, higher++);
                if (userInput == number)
                {
                    Console.WriteLine($"Совершенно верно, вам потребовалось всего " + i +" попыток!");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно, попробуйте еще раз!");
                    Console.WriteLine($"У вас осталось " + (tryesCount - i) + " попыток!");
                    Console.Write("Введите число: ");
                    Console.ReadLine();
                }
                if (i == tryesCount - 1)
                {
                    Console.WriteLine("Попытки кончились :(");
                    Console.WriteLine("Загаданное число было " + number);
                }
            }
           
        }
    }
}