using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day10
    {
        public void QuickSort(int [] arr, int low, int high)
        {

            if(low >= high)
                return;

            //Dutch national flag concept of dividing array into three sections...
            DutchNationFlagPartition(arr, low, high,out int i,out int j);

            QuickSort(arr, low, i);
            QuickSort(arr,high,j);

            foreach(int p in arr)
                Console.WriteLine(p);
        }

        public void MergeSort(int [] arr)
        {
            int mid = 0, left = 0, right = arr.Length;
        }

        private void DutchNationFlagPartition(int[] arr, int low, int high, out int i, out int j)
        {
            //To handle two element..
            if(high - low <=1)
            {
                if (arr[low] > arr[high])
                    Swap(ref arr[low], ref arr[high]);
                i = low;
                j = high;
            }

            int mid = low;
            int pivot = arr[high];
            while(mid < high)
            {
                if(arr[mid] < pivot)
                    Swap(ref arr[low++], ref arr[mid++]);
                else if(arr[mid] == pivot)
                    mid++;
                else if(arr[mid]> pivot)
                     Swap( ref arr[mid], ref arr[high--]);
            }
            i = low - 1;
            j = mid;
        }

        private void Swap(ref int lhs, ref int rhs)
        {
            int temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
