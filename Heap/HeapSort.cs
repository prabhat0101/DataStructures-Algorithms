using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class HeapSort
    {
        public void MaxHeapify(int[] A, int maxIndex, int index)
        {
            var left = 2 * index + 1;
            var right = 2 * index + 2;
            var largest = index;
            if (maxIndex > left && A[left] > A[largest])
                largest = left;
            if (maxIndex > right && A[right] > A[largest])
                largest = right;
            if(largest != index)
            {
                var temp = A[index];
                A[index] = A[largest];
                A[largest] = temp;
                MaxHeapify(A, maxIndex, largest);
            }            
        }

        public void Sort(int[] A)
        {
            var n = A.Length;
            for (int i = n / 2 - 1; i > -1; i--)
            {
                MaxHeapify(A,n,i);
            }

            for(int j = n-1; j > 0; j--)
            {
                var temp = A[0];
                A[0] = A[j];
                A[j] = temp;
                MaxHeapify(A, j, 0);
            }
            
            foreach (var i in A)
            {
                Console.WriteLine(i);
            }
        }
    }    
}
