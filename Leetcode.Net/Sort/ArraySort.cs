using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Sort
{
    public class ArraySort
    {

        public void QuickSort(int[] array, int start, int end)
        {
            if (array == null || array.Length <= 1 || start >= end)
            {
                return;
            }
            else
            {
                int temp = 0;
                int mid = array[end];
                int left = start;
                int right = end - 1;

                while(left < right)
                {
                    while (array[left] < mid && left < right)
                        left++;

                    while (array[right] >= mid && left < right)
                        right--;


                    temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }

                if(array[left] < mid)
                {
                    left++;
                }
                else
                {
                    temp = array[left];
                    array[left] = array[end];
                    array[end] = temp;
                }

                QuickSort(array, start, left - 1);
                QuickSort(array, left + 1, end);
            }
        }


        public void QuickSort(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return;
            }
            else
            {
                QuickSort(array, 0, array.Length - 1);
            }
        }


        public void Run()
        {
            int[] arr1 = new int[] { 1, 5, 9865, 213, 5, 25, 54, 4, 5, 5, 1, 5, 9, 13, 15 };
            int[] arr2 = new int[] { 2, 18, 4, 6, 13, 1, 8, 1, 0, 20, 3, 50, 36, 9, 8, 7, 52, 651, 65, 654, 564, 123, 654, 32, 82, 38, 3, 98741, 0, 50, 80 };
            DisplayArray(arr1);
            QuickSort(arr1);
            DisplayArray(arr1);


            DisplayArray(arr2);
            QuickSort(arr2);
            DisplayArray(arr2);
        }

        public void DisplayArray(int[] arr)
        {
            if(arr == null)
            {
                Console.WriteLine("NULL");
            }

            for(int i=0; i<arr.Length;i ++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("");
        }
    }
}
