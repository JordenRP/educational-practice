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

            // Подсчет строк
            int count = lines.Length;

            Console.WriteLine($"Количество строк в файле: {count}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка при чтении файла:");
            Console.WriteLine(e.Message);
        }
    }
}
