using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символ:");
        char symbol = Console.ReadLine()[0]; // Считываем первый введенный символ

        int code = symbol; // Преобразование символа в его числовой код

        Console.WriteLine($"Соответствие символа '{symbol}' его кодировке: {code}");
    }
}
