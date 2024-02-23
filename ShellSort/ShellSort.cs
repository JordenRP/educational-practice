using System;

public class ShellSortExample
{
    public static void Main(string[] args)
    {
        // Исходный массив
        int[] array = { 23, 45, 12, 8, 33, 56, 4, 89 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Сортировка Шелла
        ShellSort(array);

        // Выводим отсортированный массив
        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);

        // Модификация: ввод элементов пользователем
        Console.WriteLine("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] userInputArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите элемент {i + 1}:");
            userInputArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Сортировка введенного массива
        ShellSort(userInputArray);
        Console.WriteLine("Отсортированный пользовательский массив:");
        PrintArray(userInputArray);
    }

    static void ShellSort(int[] array)
    {
        int n = array.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = array[i];
                int j;
                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }
                array[j] = temp;
            }
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
