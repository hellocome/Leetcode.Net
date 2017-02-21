using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_15_ThreeSum
    {
        public void Run()
        {
            // new int[] {0,0,0 -11, -3, -6, 12, -15, -13, -7, -3, 13, -2, -10, 3, 12, -12, 6, -6, 12, 9, -2, -12, 14, 11, -4, 11, -8, 8, 0, -12, 4, -5, 10, 8, 7, 11, -3, 7, 5, -3, -11, 3, 11, -13, 14, 8, 12, 5, -12, 10, -8, -7, 5, -9, -11, -14, 9, -12, 1, -6, -8, -10, 4, 9, 6, -3, -3, -12, 11, 9, 1, 8, -10, -3, 2, -11, -10, -1, 1, -15, -6, 8, -7, 6, 6, -10, 7, 0, -7, -7, 9, -8, -9, -9, -14, 12, -5, -10, -15, -9, -15, -7, 6, -10, 5, -7, -14, 3, 8, 2, 3, 9, -12, 4, 1, 9, 1, -15, -13, 9, -14, 11, 9 }
            IList < IList < int >> list = ThreeSum(new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 });
            for (int i=0; i< list.Count; i++)
            {
                for(int k =0; k<list[i].Count; k++)
                {
                    Console.Write(list[i][k] + " ");
                }
                Console.WriteLine("");
            }
        }


        public void Run_2()
        {
            // new int[] {0,0,0 -11, -3, -6, 12, -15, -13, -7, -3, 13, -2, -10, 3, 12, -12, 6, -6, 12, 9, -2, -12, 14, 11, -4, 11, -8, 8, 0, -12, 4, -5, 10, 8, 7, 11, -3, 7, 5, -3, -11, 3, 11, -13, 14, 8, 12, 5, -12, 10, -8, -7, 5, -9, -11, -14, 9, -12, 1, -6, -8, -10, 4, 9, 6, -3, -3, -12, 11, 9, 1, 8, -10, -3, 2, -11, -10, -1, 1, -15, -6, 8, -7, 6, 6, -10, 7, 0, -7, -7, 9, -8, -9, -9, -14, 12, -5, -10, -15, -9, -15, -7, 6, -10, 5, -7, -14, 3, 8, 2, 3, 9, -12, 4, 1, 9, 1, -15, -13, 9, -14, 11, 9 }
            Console.Write(ThreeSumClosest(new int[] { 1, 1, 1, 1 }, 0));

        }

        public int ThreeSumClosest(int[] nums, int target)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<long> numsList = new List<long>();


            if (nums == null || nums.Length < 3)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    numsList.Add(nums[i]);
                }

                
                numsList = RebuildList_3(numsList);
                numsList.Sort(IntComparison);

                List<string> str = new List<string>();
                
                long close = int.MaxValue;
                long ret = 0;


                for (int i = 0; i < numsList.Count - 2; i++)
                {
                    int left = i + 1;
                    int right = numsList.Count - 1;


                    while (left < right)
                    {
                        long sum = numsList[i] + numsList[left] + numsList[right];
                        long distance = sum - target;

                        if(distance == 0)
                        {
                            return target;
                        }
                        else if(distance > 0)
                        {
                            long abs = Math.Abs(distance);

                            if (abs < close)
                            {
                                close = abs;
                                ret = sum;
                            }

                            right--;
                        }
                        else if(distance < 0)
                        {

                            long abs = Math.Abs(distance);

                            if (abs < close)
                            {
                                close = abs;
                                ret = sum;
                            }

                            left++;
                        }
                    }
                }


                return (int)ret;
            }
        }

        private List<long> RebuildList_3(List<long> numsList)
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
                    if (Appears[numsList[i]] < 3)
                    {
                        Appears[numsList[i]] = Appears[numsList[i]] + 1;
                        retList.Add(numsList[i]);
                    }
                }             
            }

            return retList;
        }

        private List<long> RebuildList(List<long> numsList)
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
                    if (numsList[i] == 0)
                    {
                        if (Appears[numsList[i]] < 3)
                        {
                            Appears[numsList[i]] = Appears[numsList[i]] + 1;
                            retList.Add(numsList[i]);
                        }
                    }
                    else
                    {
                        if (Appears[numsList[i]] < 2)
                        {
                            Appears[numsList[i]] = Appears[numsList[i]] + 1;
                            retList.Add(numsList[i]);
                        }
                    }
                }
            }

            return retList;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<long> numsList = new List<long>();


            if (nums == null || nums.Length < 3)
            {
                return list;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    numsList.Add(nums[i]);
                }


                numsList = RebuildList(numsList);
                numsList.Sort(IntComparison);

                List<string> str = new List<string>();

                long min = 0 - numsList[numsList.Count - 1] - numsList[numsList.Count - 2];

                long temp1 = -1;
                long temp2 = -1;
                long temp3 = -1;

                for (int i = 0; i < numsList.Count - 2; i++)
                {
                    if(numsList[i] < min)
                    {
                        continue;
                    }

                    if (i - 1 >= 0 && numsList[i - 1] == numsList[i])
                    {
                        continue;
                    }

                    for (int j = i + 1; j < numsList.Count - 1; j++)
                    {
                        for (int k = j + 1; k < numsList.Count; k++)
                        {
                            if(numsList[k] < 0)
                            {
                                break;
                            }

                            long result = numsList[i] + numsList[j] + numsList[k];
                            
                            if (result == 0)
                            {
                                if (temp1!= numsList[i] || temp2 != numsList[j] || temp3 != numsList[k])
                                {
                                    List<int> subList = new List<int>();
                                    subList.Add((int)numsList[i]);
                                    subList.Add((int)numsList[j]);
                                    subList.Add((int)numsList[k]);
                                    
                                    list.Add(subList);

                                    temp1 = numsList[i];
                                    temp2 = numsList[j];
                                    temp3 = numsList[k];
                                }

                                break;
                            }
                            else if (result > 0)
                            {
                                break;
                            }
                        }
                    }
                }
                

                return list;
            }
        }



        public int IntComparison(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x > y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
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
