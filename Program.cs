using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                }
                break;
            default:
                Console.WriteLine("Ошибка: неверный выбор операции.");
                break;
        }
    }
}
