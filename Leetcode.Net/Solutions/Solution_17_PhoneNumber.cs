using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{

    class Solution_17_PhoneNumber
    {
        public void Run()
        {
            // new int[] {0,0,0 -11, -3, -6, 12, -15, -13, -7, -3, 13, -2, -10, 3, 12, -12, 6, -6, 12, 9, -2, -12, 14, 11, -4, 11, -8, 8, 0, -12, 4, -5, 10, 8, 7, 11, -3, 7, 5, -3, -11, 3, 11, -13, 14, 8, 12, 5, -12, 10, -8, -7, 5, -9, -11, -14, 9, -12, 1, -6, -8, -10, 4, 9, 6, -3, -3, -12, 11, 9, 1, 8, -10, -3, 2, -11, -10, -1, 1, -15, -6, 8, -7, 6, 6, -10, 7, 0, -7, -7, 9, -8, -9, -9, -14, 12, -5, -10, -15, -9, -15, -7, 6, -10, 5, -7, -14, 3, 8, 2, 3, 9, -12, 4, 1, 9, 1, -15, -13, 9, -14, 11, 9 }



            Console.WriteLine(DateTime.Now.ToString("ss fff"));
            IList<string> list = LetterCombinations_2("23");
            Console.WriteLine(DateTime.Now.ToString("ss fff"));
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.WriteLine(DateTime.Now.ToString("ss fff"));
             list = LetterCombinations("23");
            Console.WriteLine(DateTime.Now.ToString("ss fff"));
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        Dictionary<char, char[]> map = new Dictionary<char, char[]>()
        {
            { '2', new char[]{ 'a', 'b', 'c' } },
            { '3', new char[]{ 'd', 'e', 'f' } },
            { '4', new char[]{ 'g', 'h', 'i' } },
            { '5', new char[]{ 'j', 'k', 'l' } },
            { '6', new char[]{ 'm', 'n', 'o' } },
            { '7', new char[]{ 'p', 'q', 'r' , 's' } },
            { '8', new char[]{ 't', 'u', 'v' } },
            { '9', new char[]{ 'w', 'x', 'y','z', } }
        };

        public IList<string> LetterCombinations_2(string digits)
        {
            List<string> all = new List<string>();
            List<string> tempList = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return all;
            }
            else
            {
                char ch = digits[0];

                for (int chIndex = 0; chIndex < map[ch].Length; chIndex++)
                {
                    foreach (string str in all)
                    {
                        all.Add(str + map[ch][chIndex]);
                    }
                }

                for (int i = 0; i < digits.Length; i++)
                {
                    ch = digits[i];

                    if (ch > '1' && ch <= '9')
                    {
                        tempList.Clear();

                        if (i == 0 && all.Count == 0)
                        {
                            for (int chIndex = 0; chIndex < map[ch].Length; chIndex++)
                            {
                                all.Add(map[ch][chIndex].ToString());
                            }

                            continue;
                        }
                        
                        for (int chIndex = 0; chIndex < map[ch].Length; chIndex++)
                        {
                            foreach (string str in all)
                            {
                                tempList.Add(str + map[ch][chIndex]);
                            }
                        }

                        all.Clear();
                        all.AddRange(tempList);
                    }
                }
            }

            return all;
        }

        public IList<string> LetterCombinations(string digits)
        {
            List<string> list = new List<string>();

            return LetterCombinations(list, digits);
        }
        public IList<string> LetterCombinations(List<string> list, string digits)
        {
            List<string> tempList = new List<string>();

            if (!string.IsNullOrEmpty(digits))
            {
                char ch = digits[0];

                if (ch > '1' && ch <= '9')
                {
                    if (list.Count == 0)
                    {
                        for (int chIndex = 0; chIndex < map[ch].Length; chIndex++)
                        {
                            list.Add(map[ch][chIndex].ToString());
                        }
                    }
                    else
                    {
                        for (int chIndex = 0; chIndex < map[ch].Length; chIndex++)
                        {
                            foreach (string str in list)
                            {
                                tempList.Add(str + map[ch][chIndex]);
                            }
                        }

                        list.Clear();
                        list.AddRange(tempList);
                    }

                    if (digits.Length >= 2)
                    {
                        return LetterCombinations(list, digits.Substring(1));
                    }
                }
            }

            return list;
        }
    }
}
