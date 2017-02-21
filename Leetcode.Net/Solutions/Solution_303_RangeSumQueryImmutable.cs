using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_303_RangeSumQueryImmutable
    {
        Dictionary<int, long> sumDic = new Dictionary<int, long>();
        int[] Nums = null;
        public Solution_303_RangeSumQueryImmutable(int[] nums)
        {
            long sum = 0;

            if (nums == null)
            {
                return;
            }
            else
            {
                Nums = nums;

                for (int i = 0; i < nums.Length; i++)
                {
                    sum = sum + nums[i];
                    sumDic.Add(i, sum);
                }
            }
        }

        public int SumRange(int i, int j)
        {
            if (sumDic.Count == 0 || j < i)
            {
                return 0;
            }
            else
            {
                if (i < 0)
                {
                    i = 0;
                }

                if (j >= sumDic.Count)
                {
                    j = sumDic.Count - 1;
                }

                if (i == j)
                {
                    return Nums[i];
                }
                else
                {
                    long iMin = 0;

                    if (i > 0)
                    {
                        iMin = sumDic[i - 1];
                    }

                    return (int)(sumDic[j] - iMin);
                }
            }
        }
    }
}
