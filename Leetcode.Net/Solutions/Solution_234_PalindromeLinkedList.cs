using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_234_PalindromeLinkedList : Solution_List
    {
        public void Run()
        {
            bool head = IsPalindrome(l1221);
            
            Console.WriteLine(head);
        }

        public bool IsPalindrome(ListNode head)
        {

            ListNode temp = head;

            if (temp == null)
            {
                return true;
            }

            int count = 0;
            int mid = 0;
            int reverseStart = 0;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            if (count == 1)
            {
                return true;
            }
            else
            {
                mid = count / 2;
                reverseStart = (count % 2 == 1) ? mid + 2 : mid + 1;
                temp = head;
                count = 0;

                ListNode reverseHead = null;

                while (temp != null)
                {
                    count++;

                    if (count == reverseStart)
                    {
                        reverseHead = ReverseNode(temp);
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }

                temp = head;
                while (reverseHead != null)
                {
                    if (reverseHead.val != temp.val)
                    {
                        return false;
                    }

                    reverseHead = reverseHead.next;
                    temp = temp.next;
                }

                return true;
            }
        }


    }
}
