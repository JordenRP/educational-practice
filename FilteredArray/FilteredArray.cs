using System;
using System.Linq;

class Program
{
    static void Main()
    {
        object[] inputArray = new object[] { 881, "laugh", 16, "b", "k", "programming" };

        // Фильтрация массива для удаления всех строковых значений
        var filteredArray = inputArray.Where(item => item is int).ToArray();

        // Вывод результата
        Console.WriteLine("Массив после удаления строковых значений:");
        foreach (var item in filteredArray)
        {
            Console.WriteLine(item);
        }
    }
}
