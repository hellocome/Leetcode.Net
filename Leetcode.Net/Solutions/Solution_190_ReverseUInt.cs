using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_190_ReverseUInt
    {
        public void Run()
        {
            Console.WriteLine(reverseBits(uint.MaxValue));
            Console.WriteLine(reverseBits(1));
            Console.WriteLine(reverseBits(int.MaxValue));
        }
        public uint reverseBits(uint n)
        {
            uint newNum = 0;
            uint toAdd = 1;

            while (n > 0)
            {
                if ((n & 0x80000000) == 0x80000000)
                {
                    newNum += toAdd;
                }

                toAdd = toAdd << 1;
                n = n << 1;
            }

            return newNum;
        }
    }
}
