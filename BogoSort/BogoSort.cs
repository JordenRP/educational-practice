using System;

public class BogoSort
{
    public static void Main(string[] args)
    {
        int[] array = { 34, 2, 11, -9, 21 }; // Исходный массив
        Console.WriteLine("Исходный массив: ");
        PrintArray(array);

        BogoSortArray(array);

        Console.WriteLine("Отсортированный массив: ");
        PrintArray(array);

        // Ввод элементов пользователем
        Console.WriteLine("Введите количество элементов массива: ");
        int length = int.Parse(Console.ReadLine());
        int[] userArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            userArray[i] = int.Parse(Console.ReadLine());
        }

        BogoSortArray(userArray);
        Console.WriteLine("Отсортированный пользовательский массив: ");
        PrintArray(userArray);
    }

    static void BogoSortArray(int[] array)
    {
        while (!IsSorted(array))
        {
            ShuffleArray(array);
        }
    }

    static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
                return false;
        }
        return true;
    }

    static void ShuffleArray(int[] array)
    {
        Random rng = new Random();
        int n = array.Length;
        while (n > 1)
        {
            int k = rng.Next(n--);
            int temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
