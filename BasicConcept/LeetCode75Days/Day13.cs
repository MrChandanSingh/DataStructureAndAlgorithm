using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    internal class Day13
    {
        public int SearchPivot(int[] nums, int key, int low, int high)
        {
            int l=0,m=0,r=nums.Length-1;

            //find the smallest element index;
            while(l<r)
            {
                m= (l+r)/2;
                if (nums[m] > nums[r])
                    l = m + 1;
                else
                    r = m;
            }

            int s = l;
            l = 0;
            r= nums.Length-1;

            if(key>=nums[s] && key<=nums[r])
            {
                l = s;
            }
            else
            {
                r= s;
            }

            while(l<=r)
            {
                m= (l+r)/2;
                if (nums[m] == key)
                    return m;
                else if(nums[m] > key)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }

            return -1;

        }
    }
}
