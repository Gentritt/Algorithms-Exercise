using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	class StacksArray
	{

		int[] data;
		int top;
		public StacksArray(int n )
		{
			data = new int[n]; // the size of the array;
			top = 0;
		}

		public int length()
		{
			return top;
		}
		public bool isEmpty()
		{
			return top == 0;
			
		}

		public bool isFull()
		{
			return top == data.Length;
		}

		public void push(int e)
		{
			if (isFull())
			{
				Console.WriteLine("Stack is full");
				return;
			}
			else
			{
				data[top] = e;

				top = top + 1;
			}

		}
		public int pop()
		{
			if (isEmpty())
			{
				Console.WriteLine("Stack is empty");
				return -1;
			}
			int e = data[top - 1];
			top = top - 1;
			return e;
		}

		public int peek()
		{
			if (isEmpty())
			{
				Console.WriteLine("sttack is empty");
				return -1;
			}
			return data[top - 1];
		}

		public void display()
		{
			for (int i = 0; i < top; i++)
			{
				Console.Write("--" + data[i]);
			}
			Console.WriteLine();
		}
	}
}
