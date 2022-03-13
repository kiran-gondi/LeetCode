using System;

namespace ApressCodingInteview
{
    class Program
    {
        /*int IsPalindrome(string inputString)
        {
            int palindrome = 1;
            if(inputString != null)
            {
                int length = inputString.Length;
                int half = length >> 1;

                int i;
                for(i = 0; i < half; ++ i)
                {
                    if(inputString[i] != inputString[length - 1 - i])
                    {
                        palindrome = 0;
                        break;
                    }
                }
            }

            return palindrome;
        }

        static int IsPalindrome_solution1(uint number)
        {

            /* It returns 1 when number is palindrome, otherwise returns 0. */
            /*int NUMBER_LENGTH = 20;
            string inputString[NUMBER_LENGTH];
            Console.WriteLine(inputString, "%d", number);

            return IsPalindrome(inputString);
        }*/

        // ==================== Solution 2 ====================

        /* It returns 1 when number is palindrome, otherwise returns 0. */
        static int IsPalindrome_solution2(int number)
        {
            int reversed = 0;
            int copy = number;

            while(number != 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return (reversed == copy) ? 1 : 0;
        }

        static void Main(string[] args)
        {
            Test("Test1", 5, 1);
            Test("Test2", 33, 1);
            Test("Test3", 242, 1);
            Test("Test4", 2332, 1);

            Test("Test5", 0, 1);

            Test("Test6", 32, 0);
            Test("Test7", 233, 0);
            Test("Test8", 2331, 0);
            Test("Test9", 2322, 0);
        }

        static void Test(string testName, int number, int expected)
            {
                if(testName != null)
                    Console.WriteLine("%s begins: ", testName);

                // if(IsPalindrome_solution1(number) == expected)
                //     Console.WriteLine("solution 1 passed; ");
                // else
                //     Console.WriteLine("solution 1 FAILED; ");

                if(IsPalindrome_solution2(number) == expected)
                    Console.WriteLine("solution 2 passed.\n");
                else
                    Console.WriteLine("solution 2 FAILED.\n");
            }
    }
}
