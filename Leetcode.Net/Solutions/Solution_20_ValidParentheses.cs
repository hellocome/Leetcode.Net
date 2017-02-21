using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_20_ValidParentheses
    {
        public void Run()
        {
            string[] strs = new string[] { "{}{}{}{}{}", "[][]", "[}}}", "" };

            foreach (string str in strs)
            {
                Console.WriteLine(str + "  =   " + IsValid(str));
            }
        }


        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            else
            {
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    {
                        stack.Push(i);
                    }
                    else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                    {
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            int itemIndex = stack.Pop();

                            if (s[itemIndex] == '(' && s[i] != ')')
                            {
                                return false;
                            }
                            else if (s[itemIndex] == '[' && s[i] != ']')
                            {
                                return false;
                            }
                            else if (s[itemIndex] == '{' && s[i] != '}')
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                return stack.Count == 0;
            }
        }
    }
}
