//#53 Maximum Subarray-DS-Array

using System;

namespace _53.Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 4, -1, 7, 8 };
            int result = MaxSubArray(nums);
            Console.WriteLine("Output: {0}", result);
            Console.ReadLine();
        }

        private static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (nums[i] > sum)
                {
                    sum = nums[i];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }

            return maxSum;
        }
    }
}
