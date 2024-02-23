using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sample = "Пример строки 123! Пример.";
        HashSet<char> uniqueChars = new HashSet<char>();

        foreach (char c in sample)
        {
            // Добавление символа в HashSet автоматически обеспечивает уникальность
            uniqueChars.Add(c);
        }

        Console.WriteLine("Уникальные символы в строке:");
        foreach (char c in uniqueChars)
        {
            Console.Write(c + " ");
        }
    }
}
