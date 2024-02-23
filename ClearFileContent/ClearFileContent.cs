using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "example.txt";

        // Создание файла с текстом
        CreateFileWithText(filePath, "Пример текста в файле.");

        // Запись дополнительной информации в файл
        AppendTextToFile(filePath, "\nДополнительный текст.");

        // Вывод содержимого файла на экран
        Console.WriteLine("Содержимое файла:");
        Console.WriteLine(File.ReadAllText(filePath));

        // Удаление всей информации из файла
        ClearFileContent(filePath);

        // Вывод содержимого файла на экран после очистки
        Console.WriteLine("\nСодержимое файла после очистки:");
        Console.WriteLine(File.ReadAllText(filePath));
    }

    static void CreateFileWithText(string filePath, string text)
    {
        File.WriteAllText(filePath, text);
    }

    static void AppendTextToFile(string filePath, string text)
    {
        File.AppendAllText(filePath, text);
    }

    static void ClearFileContent(string filePath)
    {
        File.WriteAllText(filePath, string.Empty);
    }
}
