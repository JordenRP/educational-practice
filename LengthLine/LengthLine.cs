using System;

public class Program
{
    public static void Main()
    {
        string sample = "Пример строки";
        int length = 0;

        foreach (char c in sample)
        {
            length++; // Увеличиваем счетчик для каждого символа
        }

        Console.WriteLine($"Длина строки: {length}");
    }
}
