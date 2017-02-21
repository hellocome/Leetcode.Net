using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_319_BulbSwitcher
    {
        public void Run()
        {
            Console.WriteLine(BulbSwitch(9999));
        }

        public int BulbSwitch(int n)
        {
            List<bool> list = Enumerable.Repeat(true, n).ToList();

            if (n > 1)
            {
                BulbSwitch(ref list, 2);
            }

            return (from x in list where x == true select x).Count();
        }

        public void BulbSwitch(ref List<bool> list, int round)
        {
            if (round > list.Count)
            {
                return;
            }
            else
            {
                for (int i = round - 1; i < list.Count; i = i + round)
                {
                    if (list[i])
                    {
                        list[i] = false;
                    }
                    else
                    {
                        list[i] = true;
                    }
                }

                BulbSwitch(ref list, round + 1);
            }
        }
    }
}
