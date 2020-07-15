using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1460MakeTwoArraysEqualByReversingSub_arrays
    {
        public static bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
            bool can = true;
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != arr[i])
                {
                    can = false;
                    return can;
                }
            }
            return can;
        }
    }
}
