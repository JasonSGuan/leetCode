using System;
using System.Collections.Generic;
using leetCode.Easy;
using leetCode.Medium;
using leetCode.DataStruct;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            _1282GroupThePeopleGivenTheGroupSizeTheyBelongToTest();
        }

        public static void _1282GroupThePeopleGivenTheGroupSizeTheyBelongToTest()//1282. Group the People Given the Group Size They Belong To
        {
            int[] groupSizes = { 2, 1, 3, 3, 3, 2 };
            IList<IList<int>> vs = _1282GroupThePeopleGivenTheGroupSizeTheyBelongTo.GroupThePeople(groupSizes);
            foreach (IList<int> first in vs)
            {
                foreach (int second in first)
                {
                    Console.Write(second + " ");
                }
                Console.WriteLine();
            }
        }

        public static void _852PeakIndexInAMountainArrayTest()//852 Peak Index In A Mountain Array
        {
            int[] nums = { 40,48,61,75,100,99,98,39,30,10 };
            int max = _852PeakIndexInAMountainArray.PeakIndexInMountainArray(nums);

            Console.Write(max);
        }

        public static void _1403MinimumSubsequenceInNonIncreasingOrderTest()//1403 Minimum Subsequence In Non Increasing Order Test
        {
            int[] nums = { 6 };
            IList<int> resultNum = _1403MinimumSubsequenceInNonIncreasingOrder.MinSubsequence(nums);
            for (int i = 0; i < resultNum.Count; i++)
            {
                Console.Write(resultNum[i]);
                Console.Write(" ");
            }
        }

        public static void _942DIStringMatchTest()//942 DI String Match Test 
        {
            string s = Console.ReadLine();
            int[] A = _942DIStringMatch.DiStringMatch(s);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
                Console.Write(" ");
            }
        }

        public static void _832FlipAnImageTest()//832 Flipping an Image test 
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 1, 1, 0 };
            A[1] = new int[] { 1, 0, 1 };
            A[2] = new int[] { 0, 0, 0 };
            A = _832FlipAnImage.FlipAndInvertImage(A);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i][j]);
                    Console.Write(" ");
                }
                Console.Write("\r\n");
            }
        }

        public static void _977SquaresofaSortedArrayTest()//977 Squares of a Sorted Array test
        {
            int[] A = new int[5];
            A = new int[] { -4, -1, 0, 3, 10 };
            A = _977SquaresofaSortedArray.SortedSquares(A);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i]);
                Console.Write(" ");
            }
        }


        public static void _728SelfDividingNumbersTest()//832 Flipping an Image test 
        {
            int left = Convert.ToInt32(Console.ReadLine());
            int right = Convert.ToInt32(Console.ReadLine());
            IList<int> A = _728SelfDividingNumbers.SelfDividingNumbers(left, right);
            for (int i = 0; i < A.Count; i++)
            {
                Console.Write(A[i]);
                Console.Write(" ");
            }
        }
    }
}
