using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_22_GenerateParentheses
    {
        public void Run()
        {
            IList<string> strs = GenerateParenthesis(3);

            foreach (string str in strs)
            {
                Console.WriteLine(str);
            }
        }


        IList<string> list = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            string toAdd = string.Empty;
            Generate(toAdd, n, n);

            return list;
        }

        public void Generate(string toAdd, int left, int right)
        {
            if(left == 0 && right == 0)
            {
                list.Add(toAdd);
            }

            if (left <= right)
            {
                if (left > 0)
                {
                    string leftToAdd = toAdd + "(";
                    int leftAddLeft = left - 1;

                    Generate(leftToAdd, leftAddLeft, right);
                }


                if (right > left)
                {
                    string rightToAdd = toAdd + ")";
                    int rightAddright = right - 1;

                    Generate(rightToAdd, left, rightAddright);
                }
            }
        }
    }
}
