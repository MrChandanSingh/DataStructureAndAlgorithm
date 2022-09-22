using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day27
    {
        public IList<TreeNode> GenerateTrees(int n)
        {

            if (n == 0)
                return new List<TreeNode>();

            return GenerateTrees(1,n);
    }

        private IList<TreeNode> GenerateTrees(int start, int end)
        {
            if (start >= end)
                return null;

            var nodes = new List<TreeNode>();
            for(int i=start; i<=end; i++)
            {
                var leftNodes = GenerateTrees(start, i + 1);
                var rightNodes = GenerateTrees(i + 1, end);


                for(int j=0; j<leftNodes.Count; j++)
                {
                    for(int r=0; r<rightNodes.Count; r++)
                    {
                        TreeNode root = new TreeNode(i);

                        root.left = leftNodes[j];
                        root.right = rightNodes[r];

                        nodes.Add(root);
                    }
                }
            }
            return nodes;
        }
    }
}
