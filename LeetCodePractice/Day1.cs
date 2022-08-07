namespace LeetCodePractice
{
    public class Day1
    {
        public int[] RunningSumArray(int[] arr)
        {
            int [] output = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int j = i;
                int sum = 0;
                while(j==0)
                {
                    sum=sum+arr[j];
                    j--;
                }
                output[i] = sum;
            }
            return arr;
        }
    }
}