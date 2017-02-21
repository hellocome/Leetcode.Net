using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_10_RegularExpressionMatching
    {
        public void Run()
        {
            Console.WriteLine(IsMatch("aa", "a"));
            Console.WriteLine(IsMatch("aa", "aa"));
            Console.WriteLine(IsMatch("aaa", "a"));
            Console.WriteLine(IsMatch("aa", "a*"));
            Console.WriteLine(IsMatch("aa", ".*"));
            Console.WriteLine(IsMatch("ab", ".*"));
            Console.WriteLine(IsMatch("aab", "c*a*b"));
        }


        public bool IsMatch(string s, string p)
        { return false; }
    }
}
