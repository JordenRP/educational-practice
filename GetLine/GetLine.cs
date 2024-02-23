using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt"; // Путь к файлу

        try
        {
            // Чтение всех строк файла
            string[] lines = File.ReadAllLines(filePath);

            // Вывод 1-й, 3-й и 5-й строк, если они существуют
            if (lines.Length >= 1)
                Console.WriteLine("1-я строка: " + lines[0]);
            if (lines.Length >= 3)
                Console.WriteLine("3-я строка: " + lines[2]);
            if (lines.Length >= 5)
                Console.WriteLine("5-я строка: " + lines[4]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка при чтении файла:");
            Console.WriteLine(e.Message);
        }
    }
}
