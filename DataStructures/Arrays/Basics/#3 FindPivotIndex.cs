using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){

            //int[] nums = { 2,1,-1 }; // returns 0
            int[] nums = { 1,7,3,6,5,6 }; // returns 3
            //int[] nums = { 1,2,3 }; //returns -1

            //int result = PivotIndex(nums); // Time Complexity is O(n^2)
            int result = FindMiddleIndex(nums); // Time Complexity is O(n)

            //Console.WriteLine($"Pivot Index: {0}", result);
            Console.WriteLine(result);
        }

        // Time Complexity is O(n^2)
        public static int PivotIndex(int[] nums) 

        {
            int sum = 0, leftSum = 0;
            
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            
            for(int j = 0; j < nums.Length; j++)
            {
                if(leftSum == (sum - leftSum - nums[j])) 
                {
                    return j;
                }
                leftSum += nums[j];
            }
            return -1;
        }

        // Time Complexity is O(n)
        public static int FindMiddleIndex(int[] nums)
        {
            int leftSum = 0;
            int rightSum = nums.Sum();

            for(int i = 0; i < nums.Length; i++)
            {
                if(i > 0)
                {
                    leftSum += nums[i-1];
                }

                rightSum -= nums[i];

                if(leftSum == rightSum)
                    return i;
            }
            return -1;
        }
    }
}