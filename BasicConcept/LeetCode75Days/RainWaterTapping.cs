using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class RainWaterTapping
    {
	    public void GetRainWaterTapping()
        {
            int[] arr = new int[] {7,4,0,9};
            int left = 0, right = arr.Length-1;
            int totalWater = 0;
            int maxLeft=0,maxRight=0;
            while(left < right)
            {
                if(arr[left] < arr[right])
                {

                    if (maxLeft <= arr[left])
                        maxLeft = arr[left];
                    else
                        totalWater += maxLeft - arr[left];
                    left++;

                }
                else
                {
                    if(maxRight <= arr[right])
                    { maxRight = arr[right];}
                    else
                        totalWater += maxRight- arr[right];
                    right--;
                }
            }
            Console.WriteLine($"Total water to collect: {totalWater}");
        }

        public void RightSideView()
        {
            List<int> result = new List<int>();
            TreeNode treeNode = new TreeNode(1);
            treeNode.right = new TreeNode(3);
            treeNode.right.left = new TreeNode(6);
            treeNode.right.right = new TreeNode(7);
            treeNode.left = new TreeNode(2);
            treeNode.left.left= new TreeNode(4);
            treeNode.left.right = new TreeNode(5);
            treeNode.left.right.right= new TreeNode(8);

            RightView(treeNode,result,0);

            foreach(int item in result)
                Console.WriteLine(item);
        }

        private void RightView(TreeNode treeNode, List<int> result, int currentDepth)
        {
            if (treeNode == null)
                return;

            if (result.Count == currentDepth)
                result.Add(treeNode.val);

            RightView(treeNode.right,result,currentDepth+1);
            RightView(treeNode.left,result,currentDepth+1);
        }
    }
}
