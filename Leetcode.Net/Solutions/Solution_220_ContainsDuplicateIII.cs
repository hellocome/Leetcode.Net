using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Net.Sort;

namespace Leetcode.Net
{
    class Solution_220_ContainsDuplicateIII : ArraySort
    {
        public void Run()
        {
            Console.WriteLine(ContainsNearbyAlmostDuplicate(new int[] { -3, 100, 3, 7 }, 4, 4));
        }

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums == null || nums.Length < 2 || t < 0 || k == 0)
            {
                return false;
            }
            else
            {
                t = Math.Abs(t);

                int keyT = Math.Max(1, t);

                k = Math.Abs(k);
                Dictionary<int, long> window = new Dictionary<int, long>();
                Queue<int> queue = new Queue<int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int key = (int)Math.Ceiling(1.0 * nums[i] / keyT);

                    for (int j = key - 1; j <= key + 1; j++)
                    {
                        if (window.ContainsKey(j) && Math.Abs(window[j] - nums[i]) <= t)
                        {
                            return true;
                        }
                    }

                    queue.Enqueue(key);
                    window[key] = nums[i];

                    if (queue.Count > k)
                    {
                        int queueKey = queue.Dequeue();
                        window.Remove(queueKey);
                    }
                }

                return false;
            }
        }
    }
}
