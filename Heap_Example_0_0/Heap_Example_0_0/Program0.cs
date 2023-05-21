using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Example_0_0
{
    class Program0
    {
        static void Main(string[] args)
        {
            Heap0 h = new Heap0();
            /*            17            |              15              
                       /      \         |           /      \
                     15        13       |          9        13
                   /    \     /  \      |        /   \     /  \
                  9      6   5   10     |       8     6   5   10
                 / \    / \             |      / \   / 
                4   8  3   1            |     4   1 3   
            */
            int[] arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };

            int n = arr.Length;

            h.buildHeap(arr, n);
            n = h.deleteRoot(arr, n);
            h.printHeap(arr, n);

            Console.ReadKey();
        }
    }
}
