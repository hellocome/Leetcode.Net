using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_6_ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            else
            {
                if(numRows <= 1)
                {
                    return s;
                }

                string temp = string.Empty;
                int MaxInterval = (numRows - 1) * 2;

                for (int row = 0; row < numRows && row < s.Length; row++)
                {
                    int i = row;
                    int currentRowInterval = MaxInterval - 2 * row;
                    if (currentRowInterval == 0)
                    {
                        currentRowInterval = MaxInterval;
                    }

                    while (i < s.Length)
                    {
                        temp += s[i];

                        i = currentRowInterval + i;

                        currentRowInterval = Math.Abs(MaxInterval - currentRowInterval);
                        if (currentRowInterval == 0)
                        {
                            currentRowInterval = MaxInterval;
                        }
                    }
                }


                return temp;
            }
        }


        public void Run()
        {
            Console.WriteLine(Convert("ABCD", 4));
        }
    }
}
