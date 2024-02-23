using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt"; // Путь к файлу

        try
        {
            // Чтение всего текста файла
            string text = File.ReadAllText(filePath);

            // Разделение текста на слова и подсчет упоминаний "Привет"
            int count = text.Split(new char[] {' ', '\n', '\r', '.', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries)
                            .Count(word => word.Equals("Привет", StringComparison.OrdinalIgnoreCase)); // Игнорирование регистра при подсчете

            Console.WriteLine($"Слово \"Привет\" упоминается {count} раз.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка при чтении файла:");
            Console.WriteLine(e.Message);
        }
    }
}
