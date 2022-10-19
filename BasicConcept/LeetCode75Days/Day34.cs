using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    internal class Day34
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
                return false;
            var resultSet = new Dictionary<int, int>();
            isPairNodeExist(resultSet, k);
            return resultSet.Any();
        }

        private void isPairNodeExist(Dictionary<int, int> resultSet, int k)
        {
            
        }
    }
}
