using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Medium
{
    public class _1282GroupThePeopleGivenTheGroupSizeTheyBelongTo
    {
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            int[] index = new int[groupSizes.Length];
            for (int i = 0; i < index.Length; i++)
            {
                index[i] = i;
            }
            quickSort(ref groupSizes, ref index, 0, groupSizes.Length - 1);
            int length = 1;
            int lastLength = groupSizes[0];
            int count = 1;
            for (int i = 1; i < groupSizes.Length; i++)
            {
                if (groupSizes[i] != groupSizes[i - 1] || lastLength == count)
                {
                    lastLength = groupSizes[i];
                    count = 1;
                    length++;
                }
                else
                {
                    count++; 
                }
            }
            int[][] result = new int[length][];
            int j = 0;
            int k = 0;
            result[j] = new int[groupSizes[0]];
            lastLength = groupSizes[0];
            count = 0;
            for (int i = 0; i < groupSizes.Length; i++)
            {
                result[j][k] = index[i];
                k++;
                count++;
                if (i != groupSizes.Length - 1 && (groupSizes[i] != groupSizes[i + 1] || lastLength == count))
                {
                    j++;
                    result[j] = new int[groupSizes[i + 1]];
                    lastLength = groupSizes[i + 1];
                    count = 0;
                    k = 0;
                }
            }
            return result;
        }

        public static void quickSort(ref int[] nums, ref int[] index, int left, int right)
        {
            int i = left;
            int j = left - 1;
            int k = left - 1;
            int temp = nums[left];
            for (; i <= right; i++)
            {
                if (nums[i] > temp)
                {
                    int tempt = nums[i];
                    nums[i] = nums[k + 1];
                    nums[k + 1] = nums[j + 1];
                    nums[j + 1] = tempt;
                    tempt = index[i];
                    index[i] = index[k + 1];
                    index[k + 1] = index[j + 1];
                    index[j + 1] = tempt;
                    k++; j++;
                }
                else if (nums[i] == temp)
                {
                    int tempt = nums[i];
                    nums[i] = nums[k + 1];
                    nums[k + 1] = tempt;
                    tempt = index[i];
                    index[i] = index[k + 1];
                    index[k + 1] = tempt;
                    k++;
                }
            }
            if (left < j)
            {
                quickSort(ref nums, ref index, left, j);
            }
            if (k + 1 < right)
            {
                quickSort(ref nums, ref index, k + 1, right);
            }
        }
    }
}
