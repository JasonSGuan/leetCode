using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _852PeakIndexInAMountainArray
    {
        public static int PeakIndexInMountainArray(int[] A)
        {
            if (A.Length == 3) return 1;
            int maxIndex = A.Length/2;
            int left = 0;
            int right = A.Length;
            bool flag = true;
            while (flag)
            {
                if (A[maxIndex] < A[maxIndex - 1] && A[maxIndex] > A[maxIndex + 1])
                {
                    right = maxIndex;
                    maxIndex = (left + maxIndex) / 2;
                }
                else if (A[maxIndex] > A[maxIndex - 1] && A[maxIndex] < A[maxIndex + 1])
                {
                    left = maxIndex;
                    maxIndex = (right + maxIndex) / 2;
                }
                else
                {
                    flag = false;
                }
            }
            return maxIndex;
        }
    }
}
