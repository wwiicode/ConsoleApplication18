using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling
{ 
    class AlgorithmApply
    {
        public void ImplementHeapSort()
        {
            Console.WriteLine("Please enter minimum: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter maximum: ");
            int max = int.Parse(Console.ReadLine());

            int length = 100;
            int[] anArray = new int[length];

            Random numberGenerate = new Random();
            for (int i = 0; i < length; i++)
            {
                anArray[i] = numberGenerate.Next(min, max);
            }

            Console.WriteLine("Before Sorting: ");
            foreach (int element in anArray)
            {
                Console.Write("{0} ", element);
            }

            //Using HeapSort
            //HeapSortAlgorithm.TheHeapSort ApplyHeapSort = new HeapSortAlgorithm.TheHeapSort();
            //ApplyHeapSort.PerformHeapSort(anArray);

            //Using QuickSort

            HeapSortAlgorithm.TheHeapSort ApplyHeapSort = new HeapSortAlgorithm.TheHeapSort();
            ApplyHeapSort.PerformHeapSort(anArray);

            Console.Write("\n\n-----------------------------------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("After Sorting: ");

            Console.WriteLine(string.Join(",", anArray.Select(element => element.ToString()).ToArray()));

            Console.ReadLine();
        }

        public void ImplementQuickSort()
        {
            Console.WriteLine("Please enter minimum: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter maximum: ");
            int max = int.Parse(Console.ReadLine());

            int length = 100;
            int[] anArray = new int[length];

            Random numberGenerate = new Random();
            for (int i = 0; i < length; i++)
            {
                anArray[i] = numberGenerate.Next(min, max);
            }

            Console.WriteLine("Before Sorting: ");
            foreach (int element in anArray)
            {
                Console.Write("{0} ", element);
            }

            //Using HeapSort
            //HeapSortAlgorithm.TheHeapSort ApplyHeapSort = new HeapSortAlgorithm.TheHeapSort();
            //ApplyHeapSort.PerformHeapSort(anArray);

            //Using QuickSort

            QuickSortAlgorithm.QuickSort ApplyQuickSort = new QuickSortAlgorithm.QuickSort();
            ApplyQuickSort.PerformQuickSort(anArray, 0, anArray.Length - 1);

            Console.Write("\n\n-----------------------------------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("After Sorting: ");

            Console.WriteLine(string.Join(",", anArray.Select(element => element.ToString()).ToArray()));

            Console.ReadLine();
        }

        public void ImplementBubbleSort()
        {
            Console.WriteLine("Please enter minimum: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter maximum: ");
            int max = int.Parse(Console.ReadLine());

            int length = 100;
            int[] anArray = new int[length];

            Random numberGenerate = new Random();
            for (int i = 0; i < length; i++)
            {
                anArray[i] = numberGenerate.Next(min, max);
            }

            Console.WriteLine("Before Sorting: ");
            foreach (int element in anArray)
            {
                Console.Write("{0} ", element);
            }

            //Using HeapSort
            //HeapSortAlgorithm.TheHeapSort ApplyHeapSort = new HeapSortAlgorithm.TheHeapSort();
            //ApplyHeapSort.PerformHeapSort(anArray);

            //Using QuickSort

            BubbleSortAlgorithm.BubbleSort ApplyBubbleSort = new BubbleSortAlgorithm.BubbleSort();
            ApplyBubbleSort.PerformBubbleSort (anArray);

            Console.Write("\n\n-----------------------------------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("After Sorting: ");

            Console.WriteLine(string.Join(",", anArray.Select(element => element.ToString()).ToArray()));

            Console.ReadLine();
        }
    }  
  
}
