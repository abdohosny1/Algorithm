﻿namespace Segregate_Positive_And_Negative_Numbers;

    class Program
{

    public static void Segregate(int[] array,int start,int end)
    {
        if(end <= start) return;
        int mid = (start + end) / 2;
        Segregate(array, start, mid);
        Segregate(array, mid+1, end);
        Merge(array, start, end, mid);
    }

    public static void Merge(int[] array, int start, int end ,int mid)
    {
        int i, j, k;
        int left_length = mid - start + 1;
        int right_length = end - mid;

        int[] left_array = new int[left_length];
        int[] right_array = new int[right_length];

        for (i = 0; i < left_length; i++)
        {
            left_array[i] = array[start + i];
        }
        for (j = 0; j < right_length; j++)
        {
            right_array[j] = array[mid + 1 + j];
        }

        i = 0;
        j = 0;
        k = start;

        while (i < left_length && left_array[i] <= 0)
        {
            array[k] = left_array[i];
            i++;
            k++;
        }
        while (j < right_length && right_array[j] <= 0)
        {
            array[k] = right_array[j];
            j++;
            k++;
        }

        while (i < left_length)
        {
            array[k] = left_array[i];
            i++;
            k++;
        }
        while (j < right_length)
        {
            array[k] = right_array[j];
            j++;
            k++;
        }

    }
    static void Main(string[] args)
    {

        int[] array = { 6, -5, 12, 10, -9, -1 };
        Console.WriteLine(String.Join(", ", array));
        Segregate(array, 0, array.Length - 1);
        Console.WriteLine(String.Join(", ", array));
    }
}
