using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercise
{
	class BinarySearch
	{

		public int binarySearch(int[] A, int n , int key)
		{
			int Left = 0;
			int Right = n - 1;   //(5-1) = 4
			while (Left < Right) 
			{
				int middle = (Left + Right) / 2; //(0 + 4)/2 = 2;
				if (key == A[middle]) 
					return middle;
				else if (key < A[middle])
					Right = middle - 1;
				else if (key > A[middle])
						Left = middle;

			}
			return -1;

		}
	}
}
