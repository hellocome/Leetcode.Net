using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_9_PalindromeNumber
    {
        public void Run()
        {
            Console.WriteLine(IsPalindrome(123321));
            Console.WriteLine(IsPalindrome(int.MaxValue));
            Console.WriteLine(IsPalindrome(int.MinValue));
            Console.WriteLine(IsPalindrome(-123321));
            Console.WriteLine(IsPalindrome(-2147447412));
        }
        public bool IsPalindrome(int x)
        {
            int rx = 0;

            if(x < 0)
            {
                return false;
            }

            if (ReverseToUInt(x, out rx))
            {
                if(x > 0)
                {
                    return x == rx;
                }
                else
                {
                    return x + rx == 0;
                }
            }

            return false;
        }

        public bool ReverseToUInt(int x, out int rx)
        {
            long lx = x;
            lx = Math.Abs(lx);
            long number = 0;
            rx = 0;

            while (lx > 0)
            {
                number = (number * 10) + (lx % 10);
                lx = lx / 10;
            }

            if (number > int.MaxValue)
            {
                return false;
            }
            else
            {
                rx = (int)number;
                return true;
            }
        }
    }
}
