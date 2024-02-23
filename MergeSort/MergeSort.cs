using System;

class MergeSortExample
{
    public static void Main(string[] args)
    {
        // Массив для сортировки
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given array is:");
        PrintArray(arr);

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted array is:");
        PrintArray(arr);

        // Добавление элементов в массив
        Console.WriteLine("\nEnter number of additional elements:");
        int numElements = Convert.ToInt32(Console.ReadLine());
        int[] newArr = new int[arr.Length + numElements];
        arr.CopyTo(newArr, 0);

        Console.WriteLine("Enter the elements:");
        for (int i = arr.Length; i < newArr.Length; i++)
        {
            newArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Сортировка обновлённого массива
        MergeSort(newArr, 0, newArr.Length - 1);
        Console.WriteLine("Sorted array after adding new elements:");
        PrintArray(newArr);
    }

    // Функция для печати массива
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Сортировка слиянием
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Находим середину
            int middle = left + (right - left) / 2;

            // Сортируем две половины
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            // Сливаем отсортированные половины
            Merge(arr, left, middle, right);
        }
    }

    // Слияние двух половин
    static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[left + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[middle + 1 + j];

        i = 0;
        j = 0;

        int k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}
