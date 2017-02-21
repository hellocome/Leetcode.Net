using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_28_ImplementStrStr
    {
        public void Run()
        {
            Console.WriteLine(StrStr("mississippi", "issippi"));
        }
        public int StrStr(string haystack, string needle)
        {
            int indexNeedle = 0;
            int needleStart = -1;

            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }


            if (string.IsNullOrEmpty(haystack) || needle.Length > haystack.Length)
            {
                return -1;
            }


            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    needleStart = i;

                    while (indexNeedle < needle.Length && i < haystack.Length)
                    {
                        if (haystack[i] == needle[indexNeedle])
                        {
                            if (indexNeedle == needle.Length - 1)
                            {
                                return needleStart;
                            }

                            indexNeedle++;
                            i++;
                        }
                        else
                        {
                            indexNeedle = 0;
                            break;
                        }
                    }

                    i = needleStart;
                }
            }

            return -1;
        }
    }
}
