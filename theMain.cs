using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you wanna implement HeapSort or QuickSort?");
            Console.WriteLine("(Please Choose: '1' for HeapSort, '2' for QuickSort, '3' for BubbleSort)");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            { //HeapSort
                Calling.AlgorithmApply HeapObj = new Calling.AlgorithmApply();
                HeapObj.ImplementHeapSort();
            }
            if (answer == 2)
            {  //QuickSort
                Calling.AlgorithmApply QuickObj = new Calling.AlgorithmApply();
                QuickObj.ImplementQuickSort();
            }
            if (answer == 3)
            {
                Calling.AlgorithmApply BubbleObj = new Calling.AlgorithmApply();
                BubbleObj.ImplementBubbleSort();
            }
        }
    }
}
