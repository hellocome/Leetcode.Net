using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Microsoft
{
    public class MS_FindCelebrity
    {
        public bool Know(int a, int b)
        {
            return true;
        }


        public int FindCelebrity(List<int> allPeople)
        {
            int left = 0;
            int right = allPeople.Count - 1;
            int celebrity = left;

            while (left < right)
            {
                if (Know(allPeople[left], allPeople[right]) && !Know(allPeople[right], allPeople[left]))
                {
                    celebrity = right;
                    left++;
                }
                else
                {
                    celebrity = left;
                    right--;
                }
            }

            return celebrity;
        }
    }
}
