using System;

public class Program
{
    public static void BubbleSort(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap temp and arr[i]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine($"Введите {n} элементов массива: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        BubbleSort(arr);

        Console.WriteLine("\nОтсортированный массив: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
