using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_165_CompareVersion
    {
        public void Run()
        {
            Console.WriteLine(CompareVersion("1.0.1", "1"));
        }
        public int CompareVersion(string version1, string version2)
        {
            string[] v1 = version1.Split(new char[] { '.' });
            string[] v2 = version2.Split(new char[] { '.' });

            int count = 0;

            while (count < v1.Length && count < v2.Length)
            {
                int ver1 = int.Parse(v1[count]);
                int ver2 = int.Parse(v2[count]);

                if (ver1 > ver2)
                {
                    return 1;
                }
                else if (ver1 < ver2)
                {
                    return -1;
                }

                count++;
            }

            if (count == v1.Length)
            {
                for (int i = count; i < v2.Length; i++)
                {
                    int ver2 = int.Parse(v2[i]);

                    if (ver2 > 0)
                    {
                        return -1;
                    }
                }
            }
            else if (count == v2.Length)
            {
                for (int i = count; i < v1.Length; i++)
                {
                    int ver1 = int.Parse(v1[i]);

                    if (ver1 > 0)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}
