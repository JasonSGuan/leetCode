using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _942DIStringMatch
    {
        public static int[] DiStringMatch(string S)
        {
            int[] A = new int[S.Length + 1];
            int iCount = 0;
            int dCount = 0;
            char[] DI = S.ToCharArray();
            for (int i = 0; i < DI.Length; i++)
            {
                switch (DI[i])
                {
                    case 'I':iCount++; break;
                    case 'D': dCount++; break;
                }
            }
            if (iCount == 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = dCount - i;
                }
            }
            else if (dCount == 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = i;
                }
            }
            else
            {
                int iNum = 0;
                int dNum = DI.Length;
                if (DI[0] == 'I')
                {
                    A[0] = 0;
                    iNum = 1;
                }
                else
                {
                    A[0] = DI.Length;
                    dNum = DI.Length - 1;
                }
                for (int i = 1; i < DI.Length; i++)
                {
                    switch (DI[i])
                    {
                        case 'I': A[i] = iNum;iNum++; break;
                        case 'D': A[i] = dNum;dNum--; break;
                    }
                }
                A[DI.Length] = dNum;
            }
            return A;
        }
    }
}
