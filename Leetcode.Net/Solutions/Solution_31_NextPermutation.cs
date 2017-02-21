using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_31_NextPermutation
    {
        public void Run()
        {
            int[] arr = new int[] { 1,2 };
            NextPermutation(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return;
            }
            else
            {
                int temp = 0;

                for (int i = nums.Length - 1; i > 0; i--)
                {
                    if (nums[i] > nums[i - 1])
                    {
                        int tempOrgin = nums[i - 1];

                        temp = nums[i - 1];
                        nums[i - 1] = nums[i];
                        nums[i] = temp;

                        for (int t = i - 1; t < nums.Length; t++)
                        {
                            if (nums[t] < nums[i - 1] && nums[t] > tempOrgin)
                            {
                                temp = nums[t];
                                nums[t] = nums[i - 1];
                                nums[i - 1] = temp;
                            }
                        }

                        SortArrayFrom(nums, i);
                        return;
                    }
                }

                SortArrayFrom(nums, 0);
            }
        }

        private void SortArrayFrom(int[] nums, int index)
        {
            int temp = 0;
            for (int i = index; i < nums.Length - 1; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}
