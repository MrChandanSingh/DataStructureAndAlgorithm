using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class KadanesAlgorithm
    {
        public int ExecuteKadaneAlgorith(int [] arr)
        {
            int maxSoFar = int.MinValue;
            int maxEndingHere = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxEndingHere = maxEndingHere + arr[i];
                maxEndingHere = Math.Max(maxEndingHere, arr[i]);
                maxSoFar = Math.Max(maxEndingHere, maxSoFar);
            }

            return maxSoFar;
        }
    }
}
