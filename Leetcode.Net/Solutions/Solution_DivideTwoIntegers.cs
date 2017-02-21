using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_DivideTwoIntegers
    {
        public int Divide_Slow(int dividend, int divisor)
        {
            if(divisor == 0)
            {
                return int.MaxValue;
            }
            else if(dividend == 0)
            {
                return 0;
            }
            else if(divisor == 1)
            {
                return dividend;
            }
            else
            {
                bool nag = true;
                if (dividend < 0 && divisor < 0 || dividend > 0 && divisor > 0)
                {
                    nag = false;
                }

                int absDiv = Math.Abs(dividend);
                int absdivisor = Math.Abs(divisor);
                int result = 0;

                while(dividend - divisor >= 0)
                {
                    result++;
                    dividend = -divisor;
                }

                return nag ? 0 - result : result;
            }
        }

        public void Run()
        {
            Console.WriteLine(Divide(-2147483648, -1));
            Console.WriteLine(Divide(18, 0));
            Console.WriteLine(Divide(18, 20));
        }

        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return int.MaxValue;
            }
            else if (dividend == 0)
            {
                return 0;
            }
            else if (divisor == 1)
            {
                return dividend;
            }
            else
            {
                long lDiv = Math.Abs((long)dividend);
                long lDivisor = Math.Abs((long)divisor);
                long lDivisorTemp = Math.Abs((long)divisor);
                long count = 1;
                long result = 0;

                while (lDiv >= lDivisor << 1)
                {
                    lDivisor = lDivisor << 1;
                    count = count << 1;
                }


                while (lDivisor >= lDivisorTemp)
                {
                    if (lDiv - lDivisor >= 0)
                    {
                        result += count;
                        lDiv = lDiv - lDivisor;
                    }

                    count >>= 1;
                    lDivisor >>= 1;
                }

                
                if ((dividend < 0) ^ (divisor < 0))
                {
                    result = (-result);
                }

                if (result > int.MaxValue)
                {
                    return int.MaxValue;
                }
                else if (result < int.MinValue)
                {
                    return int.MinValue;
                }

                return (int)result;
            }
        }
    }
}
