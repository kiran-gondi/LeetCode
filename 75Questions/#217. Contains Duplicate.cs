using System;

/*
217. Contains Duplicate
NOTE: dictionary to get unique values in array, to check for duplicates easily

https://leetcode.com/problems/contains-duplicate/

*/
namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            
            // int[] nums = { 1,2,3,1 }; // returns true
            
             int[] nums = { 1,2,3,4 }; //returns false

            //int[] nums = {1,1,1,3,3,4,3,2,4,2}; //returns true

            bool result = ContainsDuplicate(nums); 

            Console.WriteLine(result);
        }

        
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++ )
            {
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}