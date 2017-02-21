using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_231_PowerOfTwo
    {
        bool isPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            int res = (0x40000000 % n);

            return res == 0;
        }

        public void Run()
        {
            Console.WriteLine(isPowerOfTwo(2));
            Console.WriteLine(isPowerOfTwo(4));
        }
    }
}
