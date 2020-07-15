using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1464MaximumProductOfTwoElementsInAnArray
    {
        public static int MaxProduct(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
        }
    }
}
