using System;

public class Program
{
    // Метод для нахождения суммы первых n натуральных чисел
    static int SumOfNumbers(int n)
    {
        if (n <= 0) // Базовый случай: если n равно 0, возвращаем 0
            return 0;
        else
            return n + SumOfNumbers(n - 1); // Рекурсивный вызов функции
    }

    public static void Main()
    {
        Console.WriteLine("Введите количество чисел для сложения: ");
        int n = Convert.ToInt32(Console.ReadLine()); // Чтение значения n

        int sum = SumOfNumbers(n); // Вызов рекурсивного метода для нахождения суммы
        Console.WriteLine($"Сумма первых {n} натуральных чисел: {sum}");
    }
}
