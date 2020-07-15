using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1403MinimumSubsequenceInNonIncreasingOrder
    {
        public static IList<int> MinSubsequence(int[] nums)
        {
            quickSort(ref nums, 0, nums.Length - 1);
            int sumAll = 0;
            foreach (int num in nums)
            {
                sumAll += num;
            }
            int sumMax = 0;
            int[] numResult = new int[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (sumMax + nums[i] > sumAll - nums[i])
                {
                    numResult = new int[i + 1];
                    for (int j = 0; j <= i; j++)
                    {
                        numResult[j] = nums[j];
                    }
                    break;
                }
                else
                {
                    sumMax += nums[i];
                    sumAll -= nums[i];
                }
            }
            return numResult;
        }


        public static void quickSort(ref int[] nums,int left,int right)
        {
            int i = left;
            int j = left-1;
            int k = left-1;
            int temp = nums[left];
            for (; i <= right; i++)
            {
                if (nums[i] > temp)
                {
                    int tempt = nums[i];
                    nums[i] = nums[k + 1];
                    nums[k + 1] = nums[j + 1];
                    nums[j + 1] = tempt;
                    k++;j++;
                }
                else if (nums[i] == temp)
                {
                    int tempt = nums[i];
                    nums[i] = nums[k + 1];
                    nums[k + 1] = tempt;
                    k++;
                }
            }
            if (left < j)
            {
                quickSort(ref nums, left, j);
            }
            if (k + 1 < right)
            {
                quickSort(ref nums, k + 1, right);
            }
        }
    }
}
