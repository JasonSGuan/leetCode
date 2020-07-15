using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _728SelfDividingNumbers
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> il = new List<int>();
            for (; left <= right; left++)
            {
                int n = left;
                while (n != 0)
                {
                    int x = n % 10;
                    if (x == 0)
                    {
                        break;
                    }
                    if (left % x != 0)
                    {
                        break;
                    }
                    n = n / 10;
                }
                if (n == 0)
                {
                    il.Add(left);
                }
            }
            return il;
        }
    }
}
