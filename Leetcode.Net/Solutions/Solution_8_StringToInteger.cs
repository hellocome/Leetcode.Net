using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_8_StringToInteger
    {
        public int MyAtoi(string str)
        {
            str = str.TrimStart();

            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty((str = str.TrimStart())))
            {
                return 0;
            }
            else
            {

                long number = 0;
                bool nag = false;

                if (str[0] == '-' && str.Length > 1)
                {
                    str = str.Substring(1);
                    nag = true;
                }
                else if (str[0] == '+' && str.Length > 1)
                {
                    str = str.Substring(1);
                }

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        number = (number * 10) + (str[i] - '0');

                        if (number > int.MaxValue)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (nag)
                {
                    number = 0 - number;
                }

                if (number > int.MaxValue)
                {
                    return int.MaxValue;
                }

                if(number < int.MinValue)
                {
                    return int.MinValue;
                }

                return (int)number;
            }
        }

        public void Run()
        {
            Console.WriteLine(MyAtoi("  -2147483648"));
            Console.WriteLine(MyAtoi("  -2147483648"));
            Console.WriteLine(MyAtoi("  -2147483648"));
            Console.WriteLine(MyAtoi("  -2147483648"));
        }
    }
    
}
