using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept
{
    public class Day11
    {
        public List<int> GetReassignedPriority(List<int> prioritiest)
        {
            int[] counts = new int[100];

            foreach(var priority in prioritiest)
                counts[priority]++;

            int reducedPriority = 1;
            for(int i = 0; i < counts.Length; i++)
            {
                if(counts[i]>0)
                {
                    counts[i] = reducedPriority++;
                }
            }

            for(int i = 0; i < prioritiest.Count; i++)
            {
                prioritiest[i] = counts[prioritiest[i]];
            }
            return prioritiest;
        }

        public List<int> rotateLeft(int d, List<int> arr)
        {
            //int temp =0;
            List<int> num = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (i + d < arr.Count)
                {
                    int wm = i + d;
                    num.Add(arr[wm]);
                }
            }

            for (int i = 0; i < d; i++)
            {
                num.Add(arr[i]); ;
            }

            return num;
        }


        public List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();
            var count= strings.GroupBy(x=>x).ToDictionary(x => x.Key, x => x.ToList().Count);
            foreach(string s in queries)
            {
                if(count.ContainsKey(s))
                    result.Add(count[s]);
                else
                    result.Add(0);
            }

            return result;
        }

        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            if (a.Count != b.Count)
                return null;
            List<int> result = new List<int>();
            int alice=0, bob=0;
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                    continue;
                if(a[i] > b[i])
                    alice++;
                if(a[i] < b[i])
                    bob++;
            }
            result.Add(alice);
            result.Add(bob);
            return result;
        }
    }
}
