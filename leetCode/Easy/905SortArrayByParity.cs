using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _905SortArrayByParity
    {
        public int[] SortArrayByParity(int[] A)
        {
            int oddIndex = 1;
            int evenIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    int temp = A[0];
                    A[0] = A[i];
                    A[i] = temp;
                    break;
                }
            }
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    int temp = A[evenIndex + 1];
                    A[evenIndex + 1] = A[i];
                    A[i] = temp;
                    evenIndex++;
                    oddIndex++;
                }
                else
                {
                    oddIndex++;
                }
            }
            return A;
        }
    }
}
