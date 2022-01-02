//#1 Two Sum-DS-Array

//Solution:1
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
	{
        
        Dictionary<int, int> intStore = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(inStore.ContainsKey(target-nums[i]))
            {
                return new int[] { intStore[target-nums[i]], i};
            }
            else
            {
                intStore[nums[i]] = i;    
            }
        }
        return null;
            
    }
}

//Solution:2
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
	{
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[] {i, j};
                }
            }
        }
        return new int[]{};
    }
}



//Executing C# code
using System;
using System.Collections.Generic;

namespace _1Two_Sum_DS_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            foreach (var i in result)
            {
                Console.WriteLine("{0}", i);
            }
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> intStore = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (intStore.ContainsKey(target - nums[i]))
                {
                    return new int[] { intStore[target - nums[i]], i };
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
