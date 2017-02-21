using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{

    public class Solution_1_AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode BuildListNode(int[] array)
        {
            ListNode first = new ListNode(array[0]);
            ListNode l1 = first;

            for (int i = 1; i < array.Length; i++)
            {
                l1.next = new ListNode(array[i]);
                l1 = l1.next;
            }

            return first;
        }

        public void Run()
        {
            ListNode l1 = BuildListNode(new int[] { 3, 1, 0, 0, 1, 9, 0, 1, 6, 1});
            ListNode l2 = BuildListNode(new int[] { 5, 5, 8, 6, 2, 5, 8, 2, 6, 1});


            AddTwoNumbers(l1, l2);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode first = null;
            ListNode temp = null;

            if (l1 != null && l2 != null)
            {
                string number1 = string.Empty;
                string number2 = string.Empty;

                long num1 = 0;
                long num2 = 0;

                do
                {
                    number1 = l1.val + number1;
                    l1 = l1.next;
                } while (l1 != null);


                do
                {
                    number2 = l2.val + number2;
                    l2 = l2.next;
                } while (l2 != null);

                if(long.TryParse(number1, out num1) && long.TryParse(number2, out num2))
                {
                    string sum = (num1 + num2).ToString();

                    if (sum.Length > 0)
                    {
                        first = new ListNode(int.Parse(sum[sum.Length - 1].ToString()));
                        temp = first;
                        ListNode res = null;

                        for (int i = sum.Length - 2; i >= 0; i--)
                        {
                            res = new ListNode(int.Parse(sum[i].ToString()));
                            temp.next = res;
                            temp = res;
                        }

                        return first;
                    }
                }
            }

            return null;
        }
    }
}
