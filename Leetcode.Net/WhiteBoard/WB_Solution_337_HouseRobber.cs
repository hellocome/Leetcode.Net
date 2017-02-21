using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Net.Solutions
{
		/*
	    public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }*/
		
    class Solution_337_HouseRobber : Solution_List
    {

        public class Solution
        {
			int Max = 0;
			
            public int Rob(TreeNode root)
            {
				int amount = 0;

				Search(amount, root, true);
				Search(amount, root, false);

				return Max;
            }
			
			private void Search(int amount, TreeNode node, bool stealThisNode)
			{
				if(stealThisNode)
				{
					amount += node.val;
					
					if(node.left != null)
					{
						Search(amount, node.left, false);						
					}
					else
					{
						if(amount > Max)
						{
							Max = amount;
						}
					}
					
					if(node.right != null)
					{
						Search(amount, node.right, false);						
					}
					else
					{
						if(amount > Max)
						{
							Max = amount;
						}
					}
				}
				else
				{
					if(node.left != null)
					{
						Search(amount, node.left, true);
						Search(amount, node.left, false);						
					}
					else
					{
						if(amount > Max)
						{
							Max = amount;
						}
					}
					
					if(node.right != null)
					{
						Search(amount, node.right, true);
						Search(amount, node.right, false);						
					}
					else
					{
						if(amount > Max)
						{
							Max = amount;
						}
					}
				}
			}
			
			
			public int Rob(TreeNode root)
			{
				int amount = 0;

				if (root == null)
				{
					return amount;
				}

				amount = root.val;

				if(root.left != null)
				{
					amount += Rob(root.left.left) + Rob(root.left.right);
				}
				
				if(root.right != null)
				{
					amount += Rob(root.right.left) + Rob(root.right.right);
				}


				return Math.Max(amount, Rob(root.left) + Rob(root.right));

			}
        }
    }
}
