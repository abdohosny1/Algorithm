using System;

namespace Insertion_Sort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] x = { 9, 5, 1, 4 };
			InsertionSort(x);
		}

		static void InsertionSort(int[] x)
		{
			int key = 0;int j = 0;

			Print(x, "Array After Sort");
			for (int i = 1; i < x.Length; i++)
			{
				key = x[i];

				for ( j = i-1; j >= 0; j--)
				{
					if(key < x[j])
						x[j + 1] = x[j];
					else
						break;
					
				}
				x[j+ 1] = key;
			}

			Print(x, "Array Befor Sort");

		}

		static void Print(int [] x,string message)
		{
			Console.WriteLine(message);
			for (int i = 0; i < x.Length; i++)
			{
				Console.WriteLine(x[i]);
			}
		}
	}
}
