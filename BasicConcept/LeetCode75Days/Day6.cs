using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day6
    {

        public IList<int> GetNTreePreOrderTraversal(Node node)
        {
            IList<int> result = new List<int>();
            if (node != null)
            {
                result.Add(node.val);
                foreach (var child in node.children)
                    GetNTreePreOrderTraversal(child);
            }
            return result;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int size, i;
            if (root == null)
                return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            TreeNode node;
            while(queue.Count>0)
            {
                IList<int> temp =  new List<int>();
                size = queue.Count;
                for(i= 0; i < size; i++)
                {
                    node = queue.Peek();
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if(node.right != null)
                        queue.Enqueue(node.right);

                    queue.Dequeue();
                    temp.Add(node.val);
                }
                result.Add(temp);
            }

            return result;
        }
    }

    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
