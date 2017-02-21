using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_15_FourSum
    {
        public void Run()
        {
            int[] arr = new int[] { -493, -470, -464, -453, -451, -446, -445, -407, -406, -393, -328, -312, -307, -303, -259, -253, -252, -243, -221, -193, -126, -126, -122, -117, -106, -105, -101, -71, -20, -12, 3, 4, 20, 20, 54, 84, 98, 111, 148, 149, 152, 171, 175, 176, 211, 218, 227, 331, 352, 389, 410, 420, 448, 485 };
            int[] arr1 = new int[] {1, -2, -5, -4, -3, 3, 3, 5};

            Console.WriteLine(DateTime.Now.ToString("ss fff"));
            IList<IList<int>> list = FourSum(arr1, -11);
            Console.WriteLine(DateTime.Now.ToString("ss fff"));
            for (int i = 0; i < list.Count; i++)
            {
                for (int k = 0; k < list[i].Count; k++)
                {
                    Console.Write(list[i][k] + " ");
                }
                Console.WriteLine("");
            }
        }


        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<long> numsList = new List<long>();
            List<string> strList = new List<string>();

            if (nums == null || nums.Length < 4)
            {
                return list;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    numsList.Add(nums[i]);
                }

                
                //numsList = RebuildList_4(numsList);
                numsList.Sort(IntComparison);

                List<string> str = new List<string>();
                

                for (int a = 0; a < numsList.Count - 3; a++)
                {
                    if (a > 0 && numsList[a] == numsList[a - 1])
                        continue;

                    if ((numsList[a] + numsList[numsList.Count - 3] + numsList[numsList.Count - 2] + numsList[numsList.Count - 1]) < target)
                    {
                        continue;
                    }

                    for (int b = a + 1; b < numsList.Count - 2; b++)
                    {
                        if (b > a + 1 && numsList[b] == numsList[b - 1])
                            continue;

                        if ((numsList[a] + numsList[b] + numsList[numsList.Count - 2] + numsList[numsList.Count - 1]) < target)
                        {
                            continue;
                        }

                        for (int c = b + 1; c < numsList.Count - 1; c++)
                        {
                            if (c > b + 1 && numsList[c] == numsList[c - 1])
                                continue;

                            if ((numsList[a] + numsList[b] + numsList[c] + numsList[numsList.Count - 1]) < target)
                            {
                                continue;
                            }

                            for (int d = c + 1; d < numsList.Count; d++)
                            {
                                if (d > c + 1 && numsList[d] == numsList[d - 1])
                                    continue;

                                long sum = numsList[a] + numsList[b] + numsList[c] + numsList[d];
                               

                                if (sum == target)
                                {
                                    List<int> resList = new List<int>();
                                    resList.Add((int)numsList[a]);
                                    resList.Add((int)numsList[b]);
                                    resList.Add((int)numsList[c]);
                                    resList.Add((int)numsList[d]);
                                    list.Add(resList);
                                    
                                }
                                else if (sum > target)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }


                return list;
            }
        }

        private List<long> RebuildList_4(List<long> numsList)
        {
            Dictionary<long, int> Appears = new Dictionary<long, int>();
            List<long> retList = new List<long>();

            for (int i = 0; i < numsList.Count; i++)
            {
                if (!Appears.ContainsKey(numsList[i]))
                {
                    Appears.Add(numsList[i], 1);
                    retList.Add(numsList[i]);
                }
                else
                {
                    if (Appears[numsList[i]] < 4)
                    {
                        Appears[numsList[i]] = Appears[numsList[i]] + 1;
                        retList.Add(numsList[i]);
                    }
                }             
            }

            return retList;
        }

        public int IntComparison(long x, long y)
        {
            if(x == y)
            {
                return 0;
            }
            else if(x > y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
