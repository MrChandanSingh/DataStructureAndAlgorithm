using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day12
    {
        // N: length of array, s = sum value 
        public List<int> subarraySum(int[] arr, int n, int s)
        {
            //code here
            int intialIndex = 0;
            int maxIndex = 0;
            int tempS = s;
            List<int> list = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                
                tempS = tempS- arr[i];
                if (tempS > 0)
                    continue;
                else if(tempS ==0)
                {
                    maxIndex = i;
                    list.Add(intialIndex+1);
                    list.Add(maxIndex+1);
                    break;
                }
                else
                {                   
                    i = intialIndex;
                    intialIndex++;
                    tempS = s;
                }
            }

            return list;
        }
        
    }
}
