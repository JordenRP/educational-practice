using System;

class Program
{
    static void PrintMonthName(int monthNumber)
    {
        string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        if (monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Неверный номер месяца.");
        }
        else
        {
            Console.WriteLine(months[monthNumber - 1] + ".");
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите номер месяца:");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        PrintMonthName(monthNumber);
    }
}
