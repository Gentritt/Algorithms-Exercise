using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	public class Node
	{

		public int element;
		public Node next;

		public Node(int E, Node n)
		{
			element = E;
			next = n;

		}

	}

	public class Linkedlist
	{
		private Node head;
		private Node tail;
		private int size;

		public Linkedlist(	)
		{
			head = null;
			tail = null;
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

		public void addLast(int e)
		{
			Node newest = new Node(e, null);
			if (isEmpty())
				head = newest;
			else
			{
				tail.next = newest;
			}
			tail = newest;
			size = size + 1;

		}

		public void addFirst(int e)
		{
			Node newest = new Node(e, null);
			if (isEmpty())
			{
				head = newest;
				tail = newest;
			}
			else
			{
				newest.next = head;
				head = newest;
			}
			size = size + 1;

				
		}

		public int removeFirst()
		{
			if (isEmpty())
			{
				Console.WriteLine("List is empty");
				return -1;
			}
			else
			{
				int e = head.element; //gets the first elemnt in the list;
				head = head.next; //sets another first element;
				size = size - 1; //decreases the size by -1
				if (isEmpty())
				{
					tail = null;

				}
				return e;
			}
		}

		public int removeLast()
		{
			if (isEmpty())
			{
				Console.WriteLine("List is empty");
				return -1;

			}
			Node p = head; //gets the first element;
			int i = 1;

			while(i < size - 1) //iterates till the last element;
			{
				p = p.next;
				i = i + 1;
			}
			tail = p;
			p = p.next;
			int e = p.element;
			tail.next = null;
			size = size - 1;
			return e;
		}

		public int Search(int key) // Searching a Node;
		{
			Node p = head; //gets the first element;
			int index = 0;
			while (p !=null) 
			{
				if (p.element == key) // if [p] is the same as key
					return index; //return index of key;
				p = p.next; //else p = p.next element;
				index = index + 1; // and increase index by 1;

			}
			return -1; //returns -1 if there are no elements;
		}

		public void display()
		{
			Node p = head;
			while (p != null)
			{
				Console.WriteLine(p.element+ " --> ");
				p = p.next;
			}
			Console.WriteLine();
		}
	}
}
