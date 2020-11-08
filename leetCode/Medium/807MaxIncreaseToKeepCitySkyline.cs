using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Medium
{
    public class _807MaxIncreaseToKeepCitySkyline
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            // 每行最大值
            int[] column = new int[grid.Length];
            // 每列最大值
            int[] line = new int[grid[0].Length];
            for (int i = 0; i < column.Length; i++)
            {
                int max = grid[i][0];
                for (int j = 1; j < grid[i].Length; j++)
                {
                    if (max < grid[i][j])
                    {
                        max = grid[i][j];
                    }
                }
                column[i] = max;
            }
            for (int i = 0; i < line.Length; i++)
            {
                int max = grid[0][i];
                for(int j=0;j<grid.Length;j++)
                {
                    if (max < grid[j][i])
                    {
                        max = grid[j][i];
                    }
                }
                line[i] = max;
            }
            int sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int min = line[j] < column[i] ? line[j] : column[i];
                    sum += min - grid[i][j];
                }
            }
            return sum;
        }
    }
}
