using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_13_RomanToInt
    {
        Dictionary<char, int> mapSingle = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        Dictionary<string, int> mapDouble = new Dictionary<string, int>()
        {
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900},
        };

        Dictionary<int, string> intRoman = new Dictionary<int, string>()
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X" },
            {40, "XL" },
            {50, "L" },
            {90, "XC" },
            {100, "C" },
            {400, "CD" },
            {500, "D" },
            {900, "CM" },
            {1000, "M" }
         };

        int[] intArray = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        /*
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"LD", 400},
            {"D", 500},
            {"DM", 900},
            {"M", 1000},
            Characters are additive. I is 1, II is 2, and III is 3. VI is 6 (literally, “5 and 1”), VII is 7, and VIII is 8.
        
            The tens characters (I, X, C, and M) can be repeated up to three times. At 4, you need to subtract from the next highest fives character. 
            You can't represent 4 as IIII; instead, it is represented as IV (“1 less than 5”). The number 40 is written as XL (10 less than 50), 
            41 as XLI, 42 as XLII, 43 as XLIII, and then 44 as XLIV (10 less than 50, then 1 less than 5).
   
            Similarly, at 9, you need to subtract from the next highest tens character: 8 is VIII, but 9 is IX (1 less than 10), 
            not VIIII (since the I character can not be repeated four times). The number 90 is XC, 900 is CM.
            The fives characters can not be repeated. The number 10 is always represented as X, never as VV. The number 100 is always C, never LL.
    
            Roman numerals are always written highest to lowest, and read left to right, so the order the of characters matters very much. DC is 600;
             CD is a completely different number (400, 100 less than 500). CI is 101; IC is not even a valid Roman numeral (because you can't subtract 1 directly from 100; you would need to write it as XCIX, for 10 less than 100, then 1 less than 10).
         */

        public void Run()
        {
            Console.WriteLine(RomanToInt("DCXXI"));
            Console.WriteLine(IntToRoman(621));
        }
        public int RomanToInt(string s)
        {
            int total = 0;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else
            {
                foreach (string str in mapDouble.Keys)
                {
                    if (s.Contains(str))
                    {
                        total += mapDouble[str];
                        s = s.Replace(str, "");
                    }
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (mapSingle.ContainsKey(s[i]))
                    {
                        total += mapSingle[s[i]];
                    }
                }

                return total;
            }
        }

        /* 1 to 3999 */
        public string IntToRoman(int i)
        {
            string roman = string.Empty;

            if (i < 1 || i > 3999)
            {
                return string.Empty;
            }
            else
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    while (i - intArray[j] >= 0)
                    {
                        roman += intRoman[intArray[j]];
                        i = i - intArray[j];
                    }
                }

                return roman;
            }
        }
    }
}
