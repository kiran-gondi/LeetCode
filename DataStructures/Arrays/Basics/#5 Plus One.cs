using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){

            int[] nums = { 1, 2, 3}; // returns {1, 2, 4}
            //int[] nums = { 4, 3, 2, 1 }; // returns { 4, 3, 2, 2}
            //int[] nums = { 9 }; //returns {1, 0}

            int[] result = PlusOne(nums); 

            Console.WriteLine(String.Join(",", result));
        }

        
        public static int[] PlusOne(int[] nums)
        {
            int carryOver = 1;
            var currentValue = 0;

            for(int i = nums.Length-1; i >= 0; i--){
                currentValue = nums[i] + carryOver;
                nums[i] = currentValue%10; // return from 1-9
                carryOver = currentValue/10; // if currValue = 10 returns 1
            }

            if(carryOver != 0){
                var increasedSizeArray = new int[(nums.Length + 1)];
                increasedSizeArray[0] = carryOver;

                Array.Copy(nums, 0, increasedSizeArray, 1, nums.Length);
                return increasedSizeArray;
            }
            return nums;
        }

        
    }
}