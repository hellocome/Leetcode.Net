using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_7_ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                long xl = x;
                long number = 0;
                bool nagtive = false;

                if (xl < 0)
                {
                    xl = Math.Abs(xl);
                    nagtive = true;
                }
                

                while (xl > 0)
                {
                    number = number * 10 + (xl % 10);
                    xl = xl / 10;
                }

                if (nagtive)
                {
                    number = 0 - number;
                }
                
                if(number > int.MaxValue || number < int.MinValue)
                {
                    return 0;
                }
                else
                {
                    return (int)number;
                }
            }
        }

        public int ReverseInt(int x)
        {
            try
            {
                bool nag = false;
                long lx = x;

                if (x < 0)
                {
                    lx = Math.Abs(lx);
                    nag = true;
                }

                string str = new string(lx.ToString().Reverse<char>().ToArray<char>());

                long number = long.Parse(str);

                number = nag ? 0 - number : number;

                if(number>int.MaxValue || number < int.MinValue)
                {
                    return 0;
                }
                else
                {
                    return (int)number;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public void Run()
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(Reverse(1862320));
        }
    }
}
