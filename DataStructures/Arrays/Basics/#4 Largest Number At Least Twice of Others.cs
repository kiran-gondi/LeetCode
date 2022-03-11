using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){

            int[] nums = { 3, 6, 1, 0 }; // returns 0
            //int[] nums = { 1,2, 3, 4 }; // returns 3
            //int[] nums = { 1 }; //returns -1

            //int result = PivotIndex(nums); // Time Complexity is O(n^2)
            int result = DominantIndex(nums); // Time Complexity is O(n)

            //Console.WriteLine($"Pivot Index: {0}", result);
            Console.WriteLine(result);
        }

        
        public static int DominantIndex(int[] nums)
        {
            int m1 = int.MinValue, m2 = int.MinValue, m1i = -1, m2i = -1;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > m2){
                    m2 = nums[i];
                    m2i = i;
                }

                if(m2 > m1)
                {
                    Swap(ref m1, ref m2);
                    Swap(ref m1i, ref m2i);
                }
            }

            return m1 >= (m2 * 2) ? m1i : -1;
        }

        private static void Swap(ref int m1, ref int m2)
        {
            int h = m1;
            m1 = m2;
            m2 = h;
        }
    }
}