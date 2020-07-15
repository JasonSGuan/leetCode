using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _461HammingDistance
    {
        public static int HammingDistance(int x, int y)
        {
            int count = 0;
            while (x != 0 || y != 0)
            {
                int bitx = x % 2;
                x = x / 2;
                int bity = y % 2;
                y = y / 2;
                if (bitx != bity)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
