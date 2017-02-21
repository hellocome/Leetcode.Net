using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_336_PalindromePairs
    {

        public void Run()
        {
            IList < IList < int >> List = PalindromePairs(new string[] { "abcd", "dcba", "lls", "s", "sssll" });


            foreach(IList<int> list in List)
            {
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine("");
            }
        }

        public IList<IList<int>> PalindromePairs(string[] words)
        {
            Dictionary<string, int> StringMap = new Dictionary<string, int>();
            IList<IList<int>> list = new List<IList<int>>();

            SortedSet<int> set = new SortedSet<int>();

            if (words == null || words.Length < 2)
            {
                return list;
            }

            for (int i = 0; i < words.Length; i++)
            {
                StringMap.Add(words[i], i);
                set.Add(words[i].Length);
            }


            for (int i = 0; i < words.Length; i++)
            {
                string reverseStr = new string(words[i].ToArray().Reverse().ToArray());
                int lengthOfStr = reverseStr.Length;

                if (StringMap.ContainsKey(reverseStr) && StringMap[reverseStr] != i)
                {
                    list.Add(new List<int>() { i, StringMap[reverseStr] });
                }

                foreach (int len in set)
                {
                    if (len >= lengthOfStr)
                    {
                        break;
                    }

                    string rsubLeft = reverseStr.Substring(0, lengthOfStr - len);
                    string rsubRight = reverseStr.Substring(lengthOfStr - len);

                    if (IsStringPalindrome(rsubLeft) && StringMap.ContainsKey(rsubRight))
                    {
                        list.Add(new List<int>() { i, StringMap[rsubRight] });
                    }

                    string lsubLeft = reverseStr.Substring(0, len);
                    string lsubRight = reverseStr.Substring(len);

                    if (IsStringPalindrome(lsubRight) && StringMap.ContainsKey(lsubLeft))
                    {
                        list.Add(new List<int>() { StringMap[lsubLeft], i });
                    }
                }
            }

            return list;
        }

        private bool IsStringPalindrome(String str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (right - left > 0)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
