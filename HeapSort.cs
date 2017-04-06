using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSortAlgorithm
{
    public class TheHeapSort
    {
        private int endIndex;

        private void BuildHeap(int[] arr)
        {
            int endIndex = arr.Length - 1;
            for(int i = endIndex / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Heapify(int[] arr, int currentIndex)
        {
            int left = currentIndex * 2;
            int right = currentIndex * 2 + 1;
            int largest = currentIndex;

            if (left <= endIndex && arr[left] > arr[currentIndex])
            {
                largest = left;                
            }
            if(right <= endIndex && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (currentIndex != largest)
            {
                Swap(arr, currentIndex, largest);
                Heapify(arr, largest);
            }
            
        }

        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public void PerformHeapSort(int[] arr)
        {
            BuildHeap(arr);
            for(int i = arr.Length-1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                endIndex--;
                Heapify(arr, 0);
            }
        }
    }
    
}
