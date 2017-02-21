using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_14_LongestCommonPrefix
    {
        public void Run()
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "a", "b" }));
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            int minLength = int.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                minLength = strs[i].Length > minLength ? minLength : strs[i].Length;
            }

            string pre = string.Empty;
            pre = strs[0].Substring(0, minLength);


            for (int j = 1; j < strs.Length; j++)
            {
                for (int i = 0; i < minLength; i++)
                {
                    if (pre[i] != strs[j][i])
                    {
                        minLength = i;
                        break;
                    }
                }
            }

            if(minLength == 0)
            {
                return string.Empty;
            }
            else
            {
                return strs[0].Substring(0, minLength);
            }
        }
    }
}
