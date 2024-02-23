using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello 117!";
        HashSet<char> uniqueChars = new HashSet<char>();
        int totalCharsWithoutSpaces = 0;

        foreach (char c in input)
        {
            if (c != ' ') // Пропускаем пробелы
            {
                uniqueChars.Add(c); // Добавляем символ, если он не пробел
                totalCharsWithoutSpaces++; // Считаем все символы, кроме пробела
            }
        }

        Console.WriteLine("Уникальные символы в строке:");
        foreach (char c in uniqueChars)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine($"\n{uniqueChars.Count} / {totalCharsWithoutSpaces}");
    }
}
