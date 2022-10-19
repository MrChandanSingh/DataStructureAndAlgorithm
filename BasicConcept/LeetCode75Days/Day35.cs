using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    internal class Day35
    {
        public int NumIdenticalPairs(int[] nums)
        {

            int[] arr = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]]++;
            }

            int ans = 0;
            foreach (int i in arr)
            {
                ans += i * (i - 1) / 2;
            }

            return ans;
        }

        public int NumJewelsInStones(string j, string s)
        {
            HashSet<char> sets = new HashSet<char>();

            foreach (var c in j)
                sets.Add(c);

            int count = 0;
            foreach(var c in s)
            {
                if (sets.Contains(c))
                    count++;
            }

            return count;
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {

            int[] arr = new int[101];
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]]++;
            }

            for (int j = 1; j <= 100; j++)
            {
                arr[j] += arr[j - 1];
            }

            for (int k = 0; k < nums.Length; k++)
            {
                if (nums[k] == 0)
                    res[k] = 0;
                else
                {
                    res[k] = arr[nums[k] - 1];
                }
            }

            return res;
        }

        public string DecodeMessage(string key, string message)
        {
            Dictionary<char, char?> map = new Dictionary<char, char?>();
            StringBuilder stringBuilder = new StringBuilder();
            key = key.Replace(" ", "");
            char initial = 'a';
            foreach(var item in key)
            {
                if(!map.ContainsKey(item))
                {
                    map.Add(item, initial++);
                }
            }

            foreach(var m in message)
            {
                if (map.ContainsKey(m))
                    stringBuilder.Append(map[m]);
                else
                    stringBuilder.Append(m);

            }

            return stringBuilder.ToString();
        }

        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int count = 0;
            HashSet<int> map = new HashSet<int>();
            foreach (var item in nums)
                map.Add(item);

            foreach(var item in nums)
            {
                var sum = item + diff;
                var difference = item - diff;
                if (map.Contains(sum) && map.Contains(difference))
                    count++;
            }

            return count;
        }

        public string[] SortPeople(string[] names, int[] heights)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();
            
            for(int k=0;k<names.Length;k++)
            {
                map.Add(heights[k],names[k]);
            }

            //sort the heights

           var result = map.OrderByDescending(x => x.Key).Select(x=>x.Value);
            return result.ToArray();
        }

        public bool CheckIfPangram(string sentence)
        {
            var arr = new int[123];
            var initial = 'a';
            for (int i = 0; i < 26; i++)
            {
                arr[initial++] = 0;
            }

            foreach(char c in sentence)
            {
                arr[c]++;
            }

            for(int i = 97; i < arr.Length;i++)
            {
                if(arr[i]<1)
                    return false;
            }

            return true;
        }

        public int UniqueMorseRepresentations(string[] words)
        {
            var dic = new Dictionary<char, string>();
            var initial = 'a';
            var givenInput = new string[] {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
            foreach(var input in givenInput)
            {
                dic.Add(initial++, input);
            }

            HashSet<string> result = new HashSet<string>();
           foreach(var word in words)
            {
                StringBuilder builder = new StringBuilder();
                for(int i=0;i<word.Length;i++)
                {
                    builder.Append(dic[word[i]]);
                }
                if(!result.Contains(builder.ToString()))
                    result.Add(builder.ToString());
            }

           return result.Count;

        }
    }
}
