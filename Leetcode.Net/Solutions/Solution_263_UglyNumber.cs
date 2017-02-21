using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_263_UglyNumber
    {
        public bool IsUgly(int num)
        {

            if (num < 1)
            {
                return false;
            }
            else if (num == 1)
            {
                return true;
            }
            else
            {
                bool ugly = IsUglyToK(ref num, 5);

                if (!ugly)
                {
                    ugly = IsUglyToK(ref num, 3);
                }

                if (!ugly)
                {
                    ugly = IsUglyToK(ref num, 2);
                }

                return ugly;
            }

        }

        private bool IsUglyToK(ref int num, int k)
        {
            while (num >= 1 && num % k == 0)
            {
                num = num / k;
            }

            if (num == 1)
            {
                return true;
            }

            return false;
        }
    }
}
