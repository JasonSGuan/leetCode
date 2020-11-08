using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Medium
{
    public class _1409QueriesOnAPermutationWithKey
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            int[] P = new int[m];
            for (int i = 0; i < m; i++)
            {
                P[i] = i + 1;
            }
            for (int i = 0; i < queries.Length; i++)
            {
                int num = queries[i];
                for (int j = 0; j < m; j++)
                {
                    if (num == P[j])
                    {
                        queries[i] = j;
                    }
                }
                num = queries[i];
                int x = P[num];
                for (int j = num; j > 0; j--)
                {
                    P[j] = P[j - 1];
                }
                P[0] = x;
            }
            return queries;
        }
    }
}
