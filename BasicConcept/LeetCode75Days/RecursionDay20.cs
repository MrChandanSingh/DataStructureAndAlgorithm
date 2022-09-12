using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    
    public static class RecursionDay20
    {
        public static RecursionTreeNode SearchNode(RecursionTreeNode root, int val)
        {
            if(root == null)
                return null;
            if(root.val>= val)
                SearchNode(root.left, val);
            else
            {
                SearchNode(root.right, val);
            }

            return root;
        }
    }

    public class RecursionTreeNode
    {
        public int val;
        public RecursionTreeNode left;
        public RecursionTreeNode right;
        public RecursionTreeNode(int val = 0, RecursionTreeNode left = null, RecursionTreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
