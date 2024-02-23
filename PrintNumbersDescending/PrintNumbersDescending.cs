using System;

class Program
{
    // Метод для печати чисел от n до 1
    static void PrintNumbersDescending(int n)
    {
        if (n < 1) // Базовый случай: если n меньше 1, завершаем рекурсию
            return;

        Console.Write(n + " "); // Печатаем текущее число
        PrintNumbersDescending(n - 1); // Рекурсивный вызов функции с уменьшенным значением n
    }

    static void Main()
    {
        Console.WriteLine("Введите количество чисел для печати: ");
        int n = Convert.ToInt32(Console.ReadLine()); // Чтение значения n

        Console.WriteLine($"Печать чисел от {n} до 1:");
        PrintNumbersDescending(n); // Вызов рекурсивного метода для печати чисел
    }
}
