using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _977SquaresofaSortedArray
    {
        public static int[] SortedSquares(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];
                for (int j = i-1; j >= 0; j--)
                {
                    if (A[j + 1] < A[j])
                    {
                        int temp = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return A;
        }
    }
}
