using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _561ArrayPartitionI
    {
        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                sum = sum + nums[i];
            }
            return sum;
        }
    }
}
