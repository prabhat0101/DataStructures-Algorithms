using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    public class QuickSort
    {
        public void Sort(int[] arr)
        {
            var n = arr.Length - 1;
            Sort(arr, 0, n);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;
            var partition = Partition(arr, left, right);
            Sort(arr, left, partition - 1);
            Sort(arr, partition + 1, right);
        }

        public int Partition(int[]arr, int left, int right)
        {
            var pivot = arr[right];
            var smaller = left;
            var bigger = right;            
            while(smaller < bigger)
            {
                while(arr[smaller] < pivot)
                {
                    smaller++;
                    //left++;
                }

                while(arr[bigger] >= pivot && bigger > smaller)
                {
                    bigger--;
                    //right--;
                }
                if (smaller < bigger)
                {
                    var temp = arr[smaller];
                    arr[smaller] = arr[bigger];
                    arr[bigger] = temp;
                }        
            }            
            arr[right] = arr[smaller];
            arr[smaller] = pivot;

            return smaller;
        }

    }
}
