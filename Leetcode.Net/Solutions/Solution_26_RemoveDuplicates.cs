using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_26_RemoveDuplicates
    {
        public int RemoveDuplicates(int[] nums)
        {
            int countLength = 0;
            int tempNum = 0;

            if (nums == null)
            {
                return 0;
            }
            else if (nums.Length <= 1)
            {
                return nums.Length;
            }
            else
            {
                tempNum = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (tempNum == nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        countLength++;

                        if (countLength != i)
                        {
                            nums[countLength] = nums[i];
                        }
                    }
                }


                return nums.Length;
            }
        }
    }
}
