using System;

public class Program
{
    // Рекурсивная функция для вычисления степени числа
    static int Power(int baseValue, int exponent)
    {
        if (exponent == 0)
            return 1; // Базовый случай
        else
            return baseValue * Power(baseValue, exponent - 1); // Рекурсивный вызов
    }

    public static void Main()
    {
        Console.WriteLine("Введите базовое значение: ");
        int baseValue = Convert.ToInt32(Console.ReadLine()); // Чтение базового значения

        Console.WriteLine("Введите экспоненту: ");
        int exponent = Convert.ToInt32(Console.ReadLine()); // Чтение экспоненты

        int result = Power(baseValue, exponent); // Вычисление степени числа
        Console.WriteLine($"Значение {baseValue} в степени {exponent} равно: {result}");
    }
}
