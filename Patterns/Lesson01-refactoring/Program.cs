using System;


namespace Lesson01_refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вас приветствует математическая программа");
            Console.Write("Пожалуйста, введите число (для выхода введите q) > ");

            string userString = Console.ReadLine();

            if(!Equals(userString.ToLower(), "q"))
            {
                bool isNumber = Int32.TryParse(userString, out int userNumber);
                if (isNumber)
                {
                    long factorialResult = Math.Factorial(userNumber);
                    if (factorialResult == -1)
                        Console.WriteLine("Введенное число слишком велико для вычисления факториала");
                    else
                        Console.WriteLine($"Факториал {userNumber} равен {factorialResult}");

                    Console.WriteLine($"Сумма от 1 до {userNumber} равна {Math.Sum(userNumber)}");
                    Console.WriteLine($"Максимальное четное число меньше {userNumber} равно {Math.MaxEven(userNumber)}");
                }
                else
                {
                    Console.WriteLine("Введенная строка не является числом!");
                }
            }

            Console.WriteLine();
            Console.Write("Для выхода нажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
