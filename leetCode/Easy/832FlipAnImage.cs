using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _832FlipAnImage
    {
        public static int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length / 2; j++)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][A[i].Length - 1 - j];
                    if (A[i][j] == 0)
                    {
                        A[i][j] = 1;
                    }
                    else
                    {
                        A[i][j] = 0;
                    }
                    if (temp == 0)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp = 0;
                    }
                    A[i][A[i].Length - 1 - j] = temp;
                }
                if (A[i].Length % 2 != 0)
                {
                    if (A[i][A[i].Length / 2] == 0)
                    {
                        A[i][A[i].Length / 2] = 1;
                    }
                    else
                    {
                        A[i][A[i].Length / 2] = 0;
                    }
                }
            }
            return A;
        }
    }
}
