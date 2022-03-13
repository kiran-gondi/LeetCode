using System;

/*
53. Maximum Subarray

NOTE: pattern: prev subarray cant be negative, dynamic programming: compute max sum for each prefix

https://leetcode.com/problems/maximum-subarray/

*/
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args){
            
             int[] nums = { -2,1,-3,4,-1,2,1,-5,4 }; // returns 6
            
            // int[] nums = { 1 }; //returns 1

            //int[] nums = { 5,4,-1,7,8 }; //returns 23

            int result = MaxSubArray(nums); 

            Console.WriteLine(result);
        }

        
        public static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];

            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if(nums[i] > sum)
                {
                    sum = nums[i];
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }

    }
}