using System;
using System.Linq;

class Program
{
    static void Main()
    {
        object[] inputArray = new object[] { "hello", 1811, "goodbye" };

        // Преобразование каждого элемента массива в строку
        var resultArray = inputArray.Select(item => item.ToString()).ToArray();

        // Вывод результата
        Console.WriteLine("Массив в символьном формате:");
        foreach (var item in resultArray)
        {
            Console.WriteLine(item);
        }
    }
}
