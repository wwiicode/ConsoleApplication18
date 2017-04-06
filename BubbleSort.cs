using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgorithm
{
    class BubbleSort
    {
        public void PerformBubbleSort(int[] arr)
        {
            for(int i = 0; i<=arr.Length-1; i++)
            {
                for(int currentIndex = 0; currentIndex < arr.Length-1; currentIndex++)
                {
                    if (arr[currentIndex] > arr[currentIndex + 1])
                    {
                        Swap(arr, currentIndex, currentIndex + 1);
                    }
                }
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
