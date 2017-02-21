using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int total = 0;
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            else
            {
                int end = nums.Length - 1;
                for (int i = 0; i <= end; i++)
                {
                    if(nums[i] == val)
                    {
                        total++;
                        while (end > i)
                        {
                            if(nums[end] == val)
                            {
                                total++;
                                end--;
                            }
                            else
                            {
                                nums[i] = nums[end];
                            }
                        }
                    }
                }

                return nums.Length - total;
            }
        }
    }
}
