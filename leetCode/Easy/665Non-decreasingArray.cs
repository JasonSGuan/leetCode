using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _665Non_decreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
            }
            if (count > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
