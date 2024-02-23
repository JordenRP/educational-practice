using System;

public class Program
{
    // Функция для нахождения n-го числа Фибоначчи
    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0; // Базовый случай
        else if (n == 1)
            return 1; // Базовый случай
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); // Рекурсивный вызов
    }

    public static void Main()
    {
        Console.WriteLine("Введите количество членов для ряда Фибоначчи: ");
        int count = Convert.ToInt32(Console.ReadLine()); // Чтение значения count

        Console.WriteLine("Числа Фибоначчи для первых " + count + " чисел серий:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(Fibonacci(i) + " "); // Печать i-го числа Фибоначчи
        }
    }
}
