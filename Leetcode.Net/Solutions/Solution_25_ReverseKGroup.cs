using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    public class Solution_25_ReverseKGroup : Solution_List
    {
        public void Run()
        {
            ListNode head = ReverseKGroup(l3, 11);

            int count = 0;

            while (head != null && count < 14)
            {
                Console.WriteLine(head.val);
                head = head.next;
                count++;
            }
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {

            if (k <= 1)
            {
                return head;
            }

            if(head == null || head.next == null)
            {
                return head;
            }

            ListNode newHead = null;
            ListNode subEnd = null;
            ListNode subHead = null;

            ListNode node = head;
            ListNode nodeNext = node.next;
            ListNode tempSubEnd = null;

            int length = 0;

            while (node != null)
            {
                subHead = ReverseK(node, k, out subEnd, out node, out length);

                if(newHead == null)
                {
                    if (length == k)
                    {
                        newHead = subHead;
                        tempSubEnd = subEnd;
                    }
                    else
                    {
                        subHead = ReverseK(subHead, k, out subEnd, out node, out length);
                        newHead = subHead;
                    }
                }
                else
                {
                    if (length == k)
                    {
                        tempSubEnd.next = subHead;
                        tempSubEnd = subEnd;
                    }
                    else
                    {
                        subHead = ReverseK(subHead, k, out subEnd, out node, out length);

                        tempSubEnd.next = subHead;
                    }
                }
            }

            if (node != null)
            {
                node.next = null;
            }

            return newHead == null ? head : newHead;
        }


        private ListNode ReverseK(ListNode head, int k, out ListNode last, out ListNode lastNext, out int length)
        {
            length = 1;
            last = head;
            lastNext = null;

            if (head == null || head.next == null)
            {
                return head;
            }
            else
            {
                ListNode curNode = head;
                ListNode nextNode = head.next;
                ListNode temp = head.next;

                while (length < k &&  nextNode != null)
                {
                    nextNode = temp;
                    temp = nextNode.next;
                    nextNode.next = curNode;

                    curNode = nextNode;
                    nextNode = temp;
                    length++;
                }

                head.next = null;
                lastNext = nextNode;

                return curNode;
            }
        }
    }
}
