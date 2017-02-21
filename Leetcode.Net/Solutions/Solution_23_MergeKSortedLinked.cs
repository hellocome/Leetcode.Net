using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_23_MergeKSortedLinked
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
            ListNode l1 = BuildListNode(new int[] { 1, 5, 9, 13, 15 });
            ListNode l2 = BuildListNode(new int[] { 2, 4, 6, 8, 10, 20, 30, 50, 80 });


            ListNode head = MergeKLists(new ListNode[] { l1, l2 });

            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode currNode = null;

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            if (l1.val < l2.val)
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

            if (l1 == null)
            {
                currNode.next = l2;
            }
            else if (l2 == null)
            {
                currNode.next = l1;
            }

            return head;
        }

        public ListNode mMergeKLists(ListNode[] lists)
        {
            if(lists == null || lists.Length == 0)
            {
                return null;
            }

            if(lists.Length == 1)
            {
                return lists[0];
            }
            else
            {
                ListNode head = MergeTwoLists(lists[0], lists[1]);
                for (int i=2; i<lists.Length; i++)
                {
                    head = MergeTwoLists(head, lists[i]);
                }

                return head;
            }
        }


        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode head = null;
            ListNode temp = null;
            List<ListNode> sortedList = Sort(lists);

            if (sortedList.Count > 0)
            {
                head = sortedList[0];

                sortedList.Remove(head);
                temp = head;

                sortedList = GetNextSort(sortedList, head.next);

                while (sortedList.Count > 0 && temp != null)
                {
                    temp.next = sortedList[0];
                    temp = temp.next;

                    sortedList.Remove(temp);
                    sortedList = GetNextSort(sortedList, temp.next);
                }
            }

            return head;
        }

        public ListNode MergeKListsSlow(ListNode[] lists)
        {
            ListNode head = GetNext(lists);

            if (head != null)
            {
                ListNode temp = head;
                ListNode next = null;

                while ((next = GetNext(lists)) != null)
                {
                    temp.next = next;
                    temp = temp.next;
                }
            }

            return head;
        }

        public ListNode GetNext(ListNode[] lists)
        {
            ListNode next = null;
            int indexToNext = -1;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    if (next == null)
                    {
                        next = lists[i];
                        indexToNext = i;
                    }
                    else
                    {
                        if (next.val > lists[i].val)
                        {
                            next = lists[i];
                            indexToNext = i;
                        }
                    }
                }
            }

            if (next != null)
            {
                lists[indexToNext] = lists[indexToNext].next;
            }

            return next;

        }

        public List<ListNode> GetNextSort(List<ListNode> lists, ListNode node)
        {
            
            int indexToInsert = -1;

            if (node != null)
            {

                for (int i = 0; i < lists.Count; i++)
                {
                    if (node.val < lists[i].val)
                    {
                        indexToInsert = i;
                        break;
                    }
                }

                if (indexToInsert == -1)
                {
                    lists.Add(node);
                }
                else
                {
                    lists.Insert(indexToInsert, node);
                }
            }

            return lists;
        }

        public List<ListNode> Sort(ListNode[] lists)
        {
            List<ListNode> nodeList = new List<ListNode>();

            foreach (ListNode node in lists)
            {
                if (node != null)
                {
                    for (int i = 0; i < nodeList.Count; i++)
                    {
                        if (node.val <= nodeList[i].val)
                        {
                            nodeList.Insert(i, node);
                            break;
                        }
                    }

                    nodeList.Add(node);
                }
            }

            return nodeList;
        }
    }
}
