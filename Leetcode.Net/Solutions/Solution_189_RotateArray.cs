using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_189_RotateArray
    {
        public void Run()
        {
            int[] arr = new int[2] { 1, 2 };
            Rotate(arr, 1);
            
            for(int i=0; i< arr.Length; i ++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 1 || k > (nums.Length - 1) || k <= 0)
            {
                return;
            }
            else
            {
                int[] newNums = new int[nums.Length];

                int max = nums.Length - k > k ? nums.Length - k : k;

                for (int i = 0; i < max; i++)
                {
                    if (i < k)
                    {
                        newNums[i] = nums[nums.Length - k + i];
                    }

                    if (i < nums.Length - k)
                    {
                        newNums[k + i] = nums[i];
                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = newNums[i];
                }
            }
        }
    }
}
