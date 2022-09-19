using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day23
    {
        public int MaxDepthOfTree(RecursionTreeNode nodes)
        {
            //RecursionTreeNode root = new RecursionTreeNode(3);
            //root.left = new RecursionTreeNode(9);
            //root.left.left = null;
            //root.left.right = null;
            //root.right = new RecursionTreeNode(20);
            //root.right.left = new RecursionTreeNode(15);
            //root.right.right = new RecursionTreeNode(7);

            RecursionTreeNode root = new RecursionTreeNode(1);
            root.left = null;
            root.right = new RecursionTreeNode(2);


            if(root == null)
                return 0;

            Queue<RecursionTreeNode> queue = new Queue<RecursionTreeNode>();
            queue.Enqueue(root);
            int depth = 0;
            while(queue.Count>0)
            {
                var size = queue.Count;
                for(int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if(node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                depth++;
            }

            return depth;
        }
    }
}
