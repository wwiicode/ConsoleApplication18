using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgorithm
{
   class QuickSort
    {
        public void PerformQuickSort(int[] arr, int begin, int end)
        {
            int low = begin;
            int high = end;
            int pivot = arr[begin + (end - begin) / 2];

            while (low < high)
            {
                while (arr[low] < pivot)
                {
                    low++;
                }
                while (arr[high] > pivot)
                {
                    high--;
                }
                if (low < high)
                {
                    Swap(arr, low, high);
                    low++;
                    high--;
                }

            }
            if (low < end)
            {
                PerformQuickSort(arr, high+1, end);
            }
            if (high > begin)
            {
                PerformQuickSort(arr, begin, low-1);
            }
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        
        
    }

}
