using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	class SortingAlgorithms
	{
		public static void selectionSort(int[] input)
		{
			for (int i = 0; i < input.Length - 1; i++)
			{
				int indexOfSmallest = i;
				for (int j  = i + 1;  j  < input.Length;  j ++)
				{

					if(input[j] < input[indexOfSmallest])
					{
						indexOfSmallest = j;
					}
				}

				int temp = input[i];
				input[i] = input[indexOfSmallest];
				input[indexOfSmallest] = temp;

			}
			

		}

		public static void SelectionSort1 (int[] A, int n)
		{
			for (int i = 0; i < n - 1; i++)
			{
				int pos = i; //saves the smallest element; 
				for (int j = i + 1; j < n; j++) // iterates in every element until it finds the smalles one;
				{
					if(A[j] < A[pos]) //check if the element is smaller than the given elemnt;
					{
						pos = j; // then swapp;
					}

				}

				int temp = A[i]; //saves the first element;
				A[i] = A[pos]; //put the smallest element at firs index;
				A[pos] = temp;


			}

		}

		public static void InsertionSort(int[] A, int n)
		
		{
			for (int i = 1; i < n; i++)
			{
				int cvalue = A[i];
				int pos = i;
				while (pos > 0 && A[pos-1] > cvalue) //checks if the index[pos] is greater
					                                 //than 0 and index[pos-1] is greeather than cvalue
				{
					A[pos] = A[pos - 1];
					pos = pos - 1;
				}
				A[pos] = cvalue;
			}

		}


		public static void BubbleSort(int[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				Boolean swapped = false;

				for (int j = 0; j + 1 < input.Length - i; j++)
				{
					if(input[j] > input[j + 1]) // if number in index[j] is bigger than index[j + 1] we swapp.
					{
						swapped = true;
						int temp = input[j];
						input[j] = input[j + 1];
						input[j + 1] = temp;
					}
				}
				if (!swapped)
					return;

			}


		}

		public static void PrintArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + ", ");
			}
			Console.WriteLine();


		}


	}
}
