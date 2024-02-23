using System;
using System.IO;
using System.Linq;

class Program
{
    static void CreateFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }

    static void WriteDataToFile(string filePath, string login, string password)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{login}:{password}");
        }
    }

    static bool CheckLogin(string filePath, string login, out string storedPassword)
    {
        storedPassword = null;
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(':');
            if (parts[0] == login)
            {
                storedPassword = parts[1];
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        string filePath = "logins.txt";
        CreateFile(filePath);

        WriteDataToFile(filePath, "user1", "pass1");
        WriteDataToFile(filePath, "user2", "pass2");

        Console.WriteLine("Введите логин:");
        string login = Console.ReadLine();
        string password;

        if (CheckLogin(filePath, login, out password))
        {
            Console.WriteLine("Введите пароль:");
            string inputPassword = Console.ReadLine();

            if (inputPassword == password)
            {
                Console.WriteLine("Успешный вход в систему.");
            }
            else
            {
                Console.WriteLine("Неверный пароль. Попробуйте снова или зарегистрируйтесь.");
            }
        }
        else
        {
            Console.WriteLine("Логин не найден");
        }
    }
}
