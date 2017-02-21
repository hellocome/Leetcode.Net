using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_343_IntegerBreak
    {
        public int IntegerBreak(int n)
        {
            long result = 1;

            if(n == 2)
            {
                return 1;
            }
            else if(n == 3)
            {
                return 2;
            }

            while (n > 4 && result <= int.MaxValue)
            {
                n = n - 3;
                result = result * 3;
            }

            if (n == 4)
            {
                result = result * 4;
            }
            else if (n == 3)
            {
                result = result * 3;
            }
            else if (n == 2)
            {
                result = result * 2;
            }

            if (result > int.MaxValue)
            {
                return 0;
            }
            else
            {
                return (int)result;
            }
        }
    }
}
