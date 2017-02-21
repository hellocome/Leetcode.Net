using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_342_PowerOfFour
    {
        public void Run()
        {
            Console.WriteLine(IsPowerOfFour_NoLoop(1162261466));
            Console.WriteLine(IsPowerOfFour_NoLoop(68));
            Console.WriteLine(IsPowerOfFour_NoLoop(16));
        }
        public bool IsPowerOfFour(int num)
        {
            ulong four = 4;
            uint unum = (uint)num;

            if (num == 1)
            {
                return true;
            }
            else
            {
                while (unum >= four)
                {
                    if (unum == four)
                    {
                        return true;
                    }

                    four = four << 2;
                }
            }

            return false;
        }

        public bool IsPowerOfFour_NoLoop(int num)
        {
            if (num <= 0 || num > int.MaxValue)
            {
                return false;
            }
            else if (num == 1)
            {
                return true;
            }
            else
            {
                if (((num & 0x55555554) == num) && ((num | (num - 1)) == (uint)(num << 1) - 1))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
