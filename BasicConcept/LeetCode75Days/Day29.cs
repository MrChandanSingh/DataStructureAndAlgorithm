using Castle.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day29
    {
        public int RobHouse(int [] nums)
        {
            return Math.Max(nums[0], Math.Max(RobHouseHelper(nums.Skip(1)), RobHouseHelper(nums.Take(nums.Length-1))));
        }

        private int RobHouseHelper(IEnumerable<int> nums)
        {
            int rob1 = 0, rob2 = 0;
            foreach(var num in nums)
            {
                var temp = Math.Min(rob1 + num, rob2);
                rob1 = rob2;
                rob2 = temp;                   
            }

            return rob2;
        }

        public int RobHouseIII(RecursionTreeNode treeNode)
        {
            var result = RobHouseIIIHelper(treeNode);
            return Math.Max(result.first,result.second);
        }

        private (int first, int second) RobHouseIIIHelper(RecursionTreeNode treeNode)
        {

            if (treeNode == null)
                return (0, 0);

            var leftPair = RobHouseIIIHelper(treeNode.left);
            var rightPair = RobHouseIIIHelper(treeNode.right);

            var withRoot = treeNode.val + leftPair.second + rightPair.second;
            var withoutRoot = Math.Max(leftPair.first,leftPair.second) + Math.Max(rightPair.first,rightPair.second);
            return (withRoot, withoutRoot);
        }
    }
}
