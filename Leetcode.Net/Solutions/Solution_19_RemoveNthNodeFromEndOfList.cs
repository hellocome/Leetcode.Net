using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_19_RemoveNthNodeFromEndOfList
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */

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
            //ListNode l1 = BuildListNode(new int[] { 1 });
            ListNode l1 = BuildListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            ListNode l2 = BuildListNode(new int[] { 5, 5, 8, 6, 2, 5, 8, 2, 6, 1 });


            l1 = RemoveNthFromEndWithoutCircle(l1, 1);


            while (l1 != null)
            {
                Console.WriteLine(l1.val);
                l1 = l1.next;
            }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;
            ListNode last = null;
            ListNode nodeBeforeToRemove = null;

            bool isCircle = false;
            int count = 1;

            while (slow != null && fast != null)
            {
                count++;
                if (count >= n)
                {
                    nodeBeforeToRemove = slow;
                }

                if (fast.next == null)
                {
                    last = fast;
                    break;
                }
                else
                {
                    fast = fast.next;

                    if (slow == fast)
                    {
                        isCircle = true;
                        break;
                    }

                    fast = fast.next;
                    slow = slow.next;
                }
            }


            if (isCircle)
            {
                slow = head.next;
                fast = fast.next;

                while (slow != fast)
                {
                    count++;
                    if (count >= n)
                    {
                        nodeBeforeToRemove = slow;
                    }

                    slow = head.next;
                    fast = fast.next;
                }

                last = slow;
            }

            if (nodeBeforeToRemove != null && nodeBeforeToRemove.next != null)
            {
                nodeBeforeToRemove.next = nodeBeforeToRemove.next.next;
            }

            return head;
        }

        public ListNode RemoveNthFromEndWithoutCircle(ListNode head, int n)
        {
            ListNode slow = null;
            ListNode fast = head;

            if (head.next == null || n <= 0)
            {
                return null;
            }

            for (int i = 0; i < n; i++)
            {
                if (fast != null)
                {
                    fast = fast.next;
                }
            }


            while (fast != null)
            {
                fast = fast.next;

                if (slow == null)
                {
                    slow = head;
                }
                else
                {
                    slow = slow.next;
                }
            }

            if (slow == null)
            {
                return head.next;
            }
            else
            {
                slow.next = slow.next.next;
            }

            return head;
        }
    }
}
