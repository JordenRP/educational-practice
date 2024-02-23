using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello 117!";
        HashSet<char> uniqueChars = new HashSet<char>();
        int totalCharsWithoutSpaces = 0;
        int uniqueCount = 0; // Счетчик для уникальных символов

        foreach (char c in input)
        {
            if (c != ' ') // Пропускаем пробелы
            {
                totalCharsWithoutSpaces++; // Считаем все символы, кроме пробела
                if (uniqueChars.Add(c)) // Add возвращает true, если элемент был добавлен
                {
                    uniqueCount++; // Увеличиваем счетчик уникальных символов
                }
            }
        }

        Console.WriteLine("Уникальные символы в строке:");
        foreach (char c in uniqueChars)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine($"\n{uniqueCount} / {totalCharsWithoutSpaces}");
    }
}
