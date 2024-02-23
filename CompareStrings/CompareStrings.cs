using System;

class Program
{
    static void CompareStrings(string str1, string str2)
    {
        int result = string.Compare(str1, str2);
        if (result < 0)
        {
            Console.WriteLine("Первая строка меньше второй.");
        }
        else if (result == 0)
        {
            Console.WriteLine("Строки равны.");
        }
        else
        {
            Console.WriteLine("Первая строка больше второй.");
        }
    }

    static void Main()
    {
        string str1 = "apple";
        string str2 = "banana";

        CompareStrings(str1, str2); // Пример сравнения
    }
}
