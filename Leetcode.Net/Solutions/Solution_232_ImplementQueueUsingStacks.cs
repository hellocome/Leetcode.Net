using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_232_ImplementQueueUsingStacks
    {    // Push element x to the back of queue.
        List<int> stack = new List<int>();

        public void Push(int x)
        {
            stack.Add(x);
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            if(stack.Count > 0)
            {
                stack.RemoveAt(0);
            }
        }

        // Get the front element.
        public int Peek()
        {
            int valueToRet = 0;
            if (stack.Count > 0)
            {
                valueToRet = stack[0];
                stack.RemoveAt(0);
            }

            return valueToRet;
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}
