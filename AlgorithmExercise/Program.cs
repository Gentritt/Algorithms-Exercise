using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	class Program
	{
		static void Main(string[] args)
		{


			//BinarySearch b = new BinarySearch();
			//int[] A = { 15,21,47,84,95 };

			int[] A1 = { 3, 5, 9, 8, 6, 2 };


			//SortingAlgorithms.SelectionSort1(A1, 6);
			//SortingAlgorithms.PrintArray(A1);
			//Console.WriteLine("Sorted Array");
			//SortingAlgorithms.InsertionSort(A1, 6);
			//SortingAlgorithms.PrintArray(A1);

			//Linkedlist l = new Linkedlist();

			//l.addLast(7);
			//l.addLast(4);
			//l.addLast(12);
			//l.display();

			//l.addFirst(15);
			//Console.WriteLine("Size: " + l.length());
			//int element = l.removeFirst();
			//Console.WriteLine("Removed elemnt: " + element);
			//int element1 = l.removeLast();
			//Console.WriteLine("Removed Last Element: "+ element1);
			//l.display();

			//int position = l.Search(4);
			//Console.WriteLine("Result : " + position);
			//Console.ReadKey();

			//--------------------------------------------->
			//StacksArray s = new StacksArray(10);
			//s.push(5);
			//s.push(3);
			//s.display();
			//Console.WriteLine("Size: " + s.length());
			//Console.WriteLine("Element popped: " + s.pop());
			//Console.WriteLine("IsEmpty" + s.isEmpty());
			//Console.WriteLine("Element popped: " + s.pop());
			//Console.WriteLine("IsEmpty" + s.isEmpty());
			//Console.ReadKey();

			///---------------------------------------------->
			///

			//QueuesArrays q = new QueuesArrays(10);
			//q.enqueue(5);
			//q.enqueue(3);
			//q.display();
			//Console.WriteLine("Size: " + q.length());
			//Console.WriteLine("Element removed: " + q.dequeue());
			//Console.WriteLine("Element removed: " + q.dequeue());
			//Console.WriteLine("Is Empty? " + q.IsEmpty());
			//Console.ReadKey();

			///--------------------------------------------->
			///
			QueuesLinked q = new QueuesLinked();
			q.enqueue(5);
			q.enqueue(3);
			q.display();
			Console.WriteLine("Size: " + q.length());
			Console.WriteLine("element removed: " + q.dequeue());


		}


		public int factorialiterative(int n)
		{
			int fact = 1;
			for (int i = 1; i <=n ; i++)
			{

				fact = fact * i;
			}
			return fact;
		}

		public int factorialrecursive(int n)
		{
			if(n == 0)
			{
				return 1;
			}
			return factorialrecursive(n - 1) * n;
		}
	}
}
