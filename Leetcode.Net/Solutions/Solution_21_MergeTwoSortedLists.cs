using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_21_MergeTwoSortedLists
    {
        public void Run()
        {
            ListNode l1 = BuildListNode(new int[] { 1, 5, 9, 13, 15 });
            ListNode l2 = BuildListNode(new int[] { 2, 4, 6, 8, 10, 20, 30, 50, 80 });


            ListNode head = MergeTwoLists(l1, l2);

            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
        }

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


        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode currNode = null;

            if(l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            if (l1.val< l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }

            currNode = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    currNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    currNode.next = l2;
                    l2 = l2.next;
                }

                currNode = currNode.next;
            }

            if(l1 == null)
            {
                currNode.next = l2;
            }
            else if(l2 == null)
            {
                currNode.next = l1;
            }

            return head;
        }
    }
}
