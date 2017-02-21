using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
    class Solution_337_HouseRobber : Solution_List
    {
        public int Rob(TreeNode root)
        {
            int amount = 0;

            if(root == null)
            {
                return amount;
            }

            int rootSteal = Search(root, true);
            int rootNotSteal = Search(root, false);

            return rootSteal > rootNotSteal ? rootSteal : rootNotSteal;
        }

        public int Rob_2(TreeNode root)
        {
            int amount = 0;

            if (root == null)
            {
                return amount;
            }

            amount = root.val;

            if (root.left != null)
            {
                amount += Rob(root.left.left);
            }

            if (root.left != null)
            {
                amount += Rob(root.right.right);
            }


            return Math.Max(amount, Rob(root.left) + Rob(root.right));

        }

        private int Search(TreeNode node, bool stealThisNode)
        {
            int amount = 0;

            if (node != null)
            {
                if (stealThisNode)
                { 
                    amount = Search(node.left, false) + Search(node.right, false) + node.val;
                }
                else
                {
                    int amountLeftSteal = Search(node.left, true);
                    int amountLeftNotSteal = Search(node.left, false);

                    int leftAmount = Math.Max(amountLeftSteal, amountLeftNotSteal);

                    int amountRightSteal = Search(node.right, true);
                    int amountRightNotSteal = Search(node.right, false);

                    int rightAmount = Math.Max(amountRightSteal, amountRightNotSteal);

                    amount = leftAmount + rightAmount;
                }
            }

            return amount;
        }
    }
}

