using System;

/*
1. TwoSum
NOTE: use dictionary to instantly check for difference value, dictionary will add index of 
last occurrence of a num, don’t use same element twice;

https://leetcode.com/problems/two-sum/

*/
namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            
            // int target = 9;
            // int[] nums = { 2, 7, 11, 15}; // returns {0, 1}
            
            // int target = 6;
            // int[] nums = { 3, 2, 4}; //returns {1, 2}

            int target = 6;
            int[] nums = {3, 3}; //returns {0, 1}

            int[] result = TwoSum(nums, target); 


            Console.WriteLine(String.Join(",", result));
        }

        
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> intStore = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++){

                if(intStore.ContainsKey(target-nums[i]))
                {
                    return new int[] { intStore[target-nums[i]], i };
                }
                else
                {
                    intStore[nums[i]] = i;
                }
            }
            return null;
        }

        
    }
}