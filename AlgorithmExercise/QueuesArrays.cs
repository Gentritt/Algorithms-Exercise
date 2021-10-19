using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	class QueuesArrays
	{
		int[] data;
		int front;
		int size;
		int rear;

		public QueuesArrays(int n)
		{
			data = new int[n];
			front = 0;
			size = 0;
			rear = 0;
		}

		public int length()
		{
			return size;
		}
		public bool IsEmpty()
		{
			return size == 0;

		}
		public bool isFull()
		{
			return size == data.Length;
		}

		public void enqueue(int e)
		{
			if (isFull())
			{
				Console.WriteLine("Is full");
				return;
			}
			else
			{
				data[rear] = e; //assing the element we are inserting.
				rear = rear + 1;
				size = size + 1;
			}
		}

		public int dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Is Empty");
				return -1;
			}
			else
			{
				int e = data[front];
				front = front + 1;
				size = size - 1;
				return e;
			}
			
		}

		public void display()
		{
			for (int i = front; i < rear; i++)
			{
				Console.Write(data[i] + " -->");

			}
			Console.WriteLine();
		}
	}
}
