using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_24_SwapNodesInPairs
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode SwapPairs(ListNode head)
        {
            ListNode temp;
            ListNode newHead;
            if (head == null || head.next == null)
            {
                return head;
            }

            newHead = head.next;

            while (head != null && head.next != null)
            {
                temp = head.next;
                head.next = head.next.next;
                temp.next = head;

                temp = head;
                head = head.next;

                if (head != null && head.next != null)
                {
                    temp.next = head.next;
                }
            }

            return newHead;
        }

        public void Run()
        {
            ListNode l2 = BuildListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            ListNode l4 = BuildListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9});
            ListNode l52 = BuildListNode(new int[] { 1 });


            ListNode head = SwapPairs(l52);

            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
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
    }
}
