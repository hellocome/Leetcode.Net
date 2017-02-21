using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    /*
    Given a string, find the length of the longest substring without repeating characters. For example, the longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.

    Subscribe to see which companies asked this question
        */
    class Solution_4_LongestSubstringWithoutRepeatingCharacters
    {
        Dictionary<char, int> charMap = new Dictionary<char, int>();
        public int BuildMap(string s)
        {
            charMap.Clear();

            int maxLength = 0;
            int maxCount = 0;
            int lastScanPoint = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                maxCount++;

                if (!charMap.ContainsKey(c))
                {
                    charMap.Add(c, i);
                }
                else
                {
                    if (charMap[c] >= lastScanPoint)
                    {
                        lastScanPoint = charMap[c];
                    }

                    maxCount = i - lastScanPoint;

                    charMap[c] = i;
                }

                maxLength = maxCount > maxLength ? maxCount : maxLength;
            }

            maxLength = maxCount > maxLength ? maxCount : maxLength;

            return maxLength;
        }



        public void Run()
        {
            string test = "aa343cdd";

            Console.WriteLine(BuildMap(test));
        }

    }
}
