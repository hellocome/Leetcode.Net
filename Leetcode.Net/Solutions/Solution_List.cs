using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public ListNode l1
        {
            get
            {
                return BuildListNode(new int[] { 1, 5, 9, 13, 15 });
            }
        }

        public ListNode l2
        {
            get
            {
                return BuildListNode(new int[] { 2, 4, 6, 8, 10, 20, 30, 50, 80 });
            }
        }
        public ListNode l3
        {
            get
            {
                return BuildListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            }
        }

        public ListNode l6
        {
            get
            {
                return BuildListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 , 9});
            }
        }

        public ListNode l12
        {
            get
            {
                return BuildListNode(new int[] { 1, 2});
            }
        }

        public ListNode l1221
        {
            get
            {
                return BuildListNode(new int[] { 1, 2, 2, 1 });
            }
        }

        public ListNode l4
        {
            get
            {
                return BuildListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            }
        }
        public ListNode l5
        {
            get
            {
                return BuildListNode(new int[] { 1 });
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

        public ListNode ReverseNode(ListNode node)
        {
            ListNode prev = null;
            ListNode curr = node;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        public ListNode ReverseNode(ListNode node, ListNode nodeNext)
        {
            if (nodeNext == null)
            {
                return node;
            }
            else
            {
                ListNode temp = nodeNext.next;
                nodeNext.next = node;

                return ReverseNode(nodeNext, temp);
            }
        }
    }
}
