using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1431KidsWiththeGreatestNumberofCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies[0];
            for (int i = 1; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }
            bool[] ifMax = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    ifMax[i] = true;
                }
                else
                {
                    ifMax[i] = false;
                }
            }
            return ifMax;
        }
    }
}
