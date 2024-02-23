using System;

public class Program
{
    // Рекурсивная функция для печати чисел от 1 до n
    public static void PrintNumbers(int current, int n)
    {
        if (current > n) // Условие остановки рекурсии
            return;

        Console.Write(current + " "); // Печать текущего числа
        PrintNumbers(current + 1, n); // Рекурсивный вызов функции с увеличением текущего числа
    }

    static void Main()
    {
        Console.WriteLine("Сколько чисел нужно напечатать: ");
        int n = Convert.ToInt32(Console.ReadLine()); // Чтение входных данных

        Console.WriteLine("Ожидаемый результат:");
        PrintNumbers(1, n); // Вызов рекурсивной функции
    }
}
