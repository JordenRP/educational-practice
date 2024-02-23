using System;

public class SelectionSortExample
{
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Находим минимальный элемент в неотсортированной части массива
            int min_index = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_index])
                    min_index = j;

            // Меняем местами найденный минимальный элемент с первым элементом
            int temp = arr[min_index];
            arr[min_index] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        SelectionSort(arr);
        Console.WriteLine("Sorted array");
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
    }
}
