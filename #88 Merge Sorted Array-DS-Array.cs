//#88 Merge Sorted Array-DS-Array


using System;

namespace _88Merge_Sorted_Array_DS_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {1, 2, 3, 0, 0, 0};
            int m = 3;

            int[] nums2 = {2, 5, 6};
            int n = 3;

            int[] result = Merge(nums1, m, nums2, n);

            Console.WriteLine(String.Join(",", result));
            Console.ReadLine();
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                k--;
                j--;
            }

            return nums1;
        }

    }
}
