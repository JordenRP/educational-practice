using System;

class Program
{
    static void Main()
    {
        int number = 12; // Входные данные
        // Перевод числа в бинарный формат
        string binaryRepresentation = Convert.ToString(number, 2);

        // Подсчет количества единиц в бинарном представлении
        int onesCount = 0;
        foreach (char bit in binaryRepresentation)
        {
            if (bit == '1')
            {
                onesCount++;
            }
        }

        // Вывод результата
        Console.WriteLine($"Бинарное представление числа {number}: {binaryRepresentation}");
        Console.WriteLine($"Количество единиц: {onesCount}");
    }
}
