using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string fileName = RequestFileName();
        string folderPath = RequestFolderPath(); // Запрашиваем путь к папке
        CreateFile(fileName, folderPath); // Создаем файл в указанной папке
    }

    // Функция для запроса имени файла
    static string RequestFileName()
    {
        Console.WriteLine("Введите имя файла: ");
        return Console.ReadLine();
    }

    // Функция для запроса пути к папке
    static string RequestFolderPath()
    {
        Console.WriteLine("Введите путь к папке для создания файла: ");
        return Console.ReadLine();
    }

    // Функция для создания файла
    static void CreateFile(string fileName, string folderPath)
    {
        string fullPath = Path.Combine(folderPath, fileName);
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath); // Создаем папку, если она не существует
        }
        using (FileStream fs = File.Create(fullPath))
        {
            Console.WriteLine($"Файл {fileName} был успешно создан в {folderPath}");
        }
    }
}
