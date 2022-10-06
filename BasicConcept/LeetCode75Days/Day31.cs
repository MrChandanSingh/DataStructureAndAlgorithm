using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    internal class Day31
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {

            //left
            IList<IList<int>> resultSet = new List<IList<int>>();
            Stack<int> currentNodeList = new Stack<int>();
            if(root == null)
                return resultSet;
            PathSum(root, targetSum, currentNodeList, resultSet);
            return resultSet;

        }

        private static void PathSum(TreeNode root, int sum, Stack<int> currentList,
                                    IList<IList<int>> result)
        {
            if (root == null)
                return;

            currentList.Push(root.val);
            if (root.left == null && root.right == null && sum == root.val)
            {
                result.Add(new List<int>(currentList.Reverse()));
                
            }
            
               if(root.left!=null) PathSum(root.left, sum - root.val, currentList, result);
               if(root.right!=null) PathSum(root.right, sum - root.val, currentList, result);
            currentList.Pop();
         }
    }
}
