using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args){
            
           /*int[] nums = { 0, 2, 1, 3, 2 }; // returns 2
           int[] nums = { 0, 1, 2, 1 }; // returns 2

            var result = Duplicate(nums);

            Console.WriteLine(result);*/
        test1();
        test2();
        test3();
        test4();
        test5();
        test6();

        }

        //================= Test Code =================
        private static void test(String testName, int[] numbers, int expected, bool invalidArgument){
            Console.WriteLine(testName + " begins: ");
            
            try {
                int duplication = Duplicate(numbers);
                
                if(!invalidArgument && duplication == expected)
                    Console.WriteLine("Passed.\n");
                else
                    Console.WriteLine("FAILED.\n");
            }
            catch(Exception e){
                if(invalidArgument)
                    Console.WriteLine("Passed.\n");
                else
                    Console.WriteLine("FAILED.\n");
            }
        }

        private static void test1(){
            int[] numbers = {2, 1, 3, 1, 0};
            test("Test1", numbers, 1, false);
        }
        
        private static void test2(){
            int[] numbers = {2, 0, 3, 1, 0};
            test("Test2", numbers, 0, false);
        }
        
        private static void test3(){
            int[] numbers = {2, 0, 4, 3, 1, 4};
            test("Test3", numbers, 4, false);
        }
        
        private static void test4(){
            int[] numbers = {2, 1, 3, 0, 4};
            test("Test4", numbers, 0, true);
        }
        
        private static void test5(){
            int[] numbers = {2, 1, 3, 0, -1};
            test("Test5", numbers, 0, true);
        }
        
        private static void test6(){
            int[] numbers = {0};
            test("Test6", numbers, 0, true);
        }

        public static int Duplicate(int[] nums){

            int length = nums.Length;
            
            int sum1 = 0;

            for(int i = 0; i < nums.Length; i++){

                if(nums[i] < 0 || nums[i] > length-2)
                {
                    throw new Exception("Invalid numbers");
                }
                sum1 += nums[i];
            }

            int sum2 = ((length-1)*(length-2)) >> 1;

            return sum1-sum2;

        }
        
        

    }
}