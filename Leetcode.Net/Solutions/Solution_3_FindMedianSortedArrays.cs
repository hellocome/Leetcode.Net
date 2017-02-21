using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_3_FindMedianSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if((nums1 == null || nums1.Length == 0) && 
                (nums2 == null || nums2.Length == 0))
            {
                return 0;
            }

            if (nums1 == null || nums1.Length == 0)
            {
                return Median(nums2);
            }
            else if (nums2 == null || nums2.Length == 0)
            {
                return Median(nums1);
            }
            else
            {
                return MediaOfSortedArrays_O1(nums1, nums2);
            }
        }


        public double Median(int[] nums1)
        {
            if (nums1 == null || nums1.Length == 0)
            {
                return 0;
            }
            else
            {
                if (nums1.Length % 2 == 1)
                {
                    return nums1[nums1.Length / 2];
                }
                else
                {
                    return (nums1[(nums1.Length / 2) - 1] + nums1[(nums1.Length / 2)]) / 2.0;
                }
            }
        }

        public void Run()
        {
            int[] nums1 = new int[] { 2,3};
            int[] nums2 = new int[] { 1};

   
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }
        
        // T(n)
        public double MediaOfSortedArrays_O1(int[] nums1, int[] nums2)
        {
            int nums1Length = nums1.Length;
            int nums2Length = nums2.Length;
            int mediaLength = (nums2Length + nums1Length + 1) / 2;
            int index1 = 0;
            int index2 = 0;

            int number1 = 0;
            int number2 = 0;

            for (int i = 0; i < mediaLength; i++)
            {
                if (index1 < nums1.Length && index2 < nums2.Length)
                {
                    if(nums1[index1] > nums2[index2])
                    {
                        number1 = nums2[index2];
                        index2++;
                    }
                    else
                    {
                        number1 = nums1[index1];
                        index1++;
                    }
                }
                else if (index1 >= nums1.Length)
                {
                    number1 = nums2[index2];
                    index2++;
                }
                else if (index2 >= nums2.Length)
                {
                    number1 = nums1[index1];
                    index1++;
                }
            }

            if ((nums1Length + nums2Length) % 2 == 1)
            {
                return number1;
            }
            else
            {
                if (index1 < nums1.Length && index2 < nums2.Length)
                {
                    number2 = nums1[index1] > nums2[index2] ? nums2[index2] : nums1[index1];
                }
                else if (index1 >= nums1.Length)
                {
                    number2 = nums2[index2];
                }
                else if (index2 >= nums2.Length)
                {
                    number2 = nums1[index1];
                }

                return (number1 + number2) / 2.0;
            }
        }


        public double MediaOfSortedArrays_O2(int[] nums1, int[] nums2)
        {

            int ml1 = (nums1.Length) / 2;
            int ml2 = (nums2.Length) / 2;

            if(nums1[ml1] == nums2[ml2])
            {
                return nums1[ml1];
            }
            else if(nums1[ml1] > nums2[ml2])
            {

            }

            return 0;
        }
    }
}
