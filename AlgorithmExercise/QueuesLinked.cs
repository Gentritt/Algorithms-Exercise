using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	class QueuesLinked
	{

		Node front;
		Node rear;
		int size;

		public QueuesLinked()
		{
			front = null;
			rear = null;
			size = 0;
		}

		public int length()
		{
			return size;

		}
		public bool isEmpty()
		{
			return size == 0;

		}

		public void enqueue(int e)
		{
			Node newest = new Node(e, null);
			if (isEmpty())
			{
				front = newest; //assiging newest node as front;
			}
			else
			{
				rear.next = newest; //we are inserting a new element of the node at the end of the queue.
			}
			rear = newest;
			size = size + 1;
		}

		public int dequeue()
		{
			if (isEmpty())
			{
				Console.WriteLine("Is Empty");
				return -1;
			}
			int e = front.element; // we retrieve the front element;
			front = front.next;
			size = size - 1;
			if (isEmpty())
				rear = null;
			return e;

		}

		public void display()
		{
			Node p = front;
			while(p!= null)
			{
				Console.Write(p.element + " -->");
				p = p.next;
			}
			Console.WriteLine();
		}

	}
}
