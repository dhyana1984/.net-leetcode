using System;
using System.Linq;

namespace LeetCodeDotNetCore.DP.Medium
{
    /*
     * 在一个 m*n 的棋盘的每一格都放有一个礼物，每个礼物都有一定的价值（价值大于 0）。
     * 你可以从棋盘的左上角开始拿格子里的礼物，并每次向右或者向下移动一格、直到到达棋盘的右下角。
     * 给定一个棋盘及其上面的礼物的价值，请计算你最多能拿到多少价值的礼物？
        示例 1:

        输入: 
        [
          [1,3,1],
          [1,5,1],
          [4,2,1]
        ]
        输出: 12
        解释: 路径 1→3→5→2→1 可以拿到最多价值的礼物
     */
    public class MaxValueGift
    {
        public int Solution(int[][] grid)
        {
            if (grid.Length == 1) return grid[0].Sum();
            var dp = new int[grid.Length][];
            for (var i = 0; i < grid.Length; i++)
            {
                dp[i] = new int[grid[i].Length];
            }
            for (var i = grid.Length - 1; i >= 0; i--)
                for (var j = grid[i].Length - 1; j >= 0; j--)
                {
                    //从最右下角开始，dp[i][j]直接等于最右下角的值
                    if (i == grid.Length - 1 && j == grid[i].Length - 1)
                    {
                        dp[i][j] = grid[i][j];
                    }
                    //如果是最后一行，此时只用dp[j+i]加上当前值，表示只能向右移动，不能向下移动
                    else if (i == grid.Length - 1)
                    {
                        dp[i][j] = dp[i][j + 1] + grid[i][j];
                    }
                    //如果是最后一列，此时只能用dp[i + 1][j]加上当前值，表示只能向下移动，不能向右移动
                    else if (j == grid[i].Length - 1)
                    {
                        dp[i][j] = dp[i + 1][j] + grid[i][j];
                    }
                    //如果不是最右下，不是最后一行或者最后一列，可以向下或者向右移动
                    else
                    {
                        //dp方程，此时从最右下角开始遍历，找出最后一步是从上往下移动还是从左向右移动，取最大值并且加上最右下的值
                        //然后起点推导，看每个最大值是向下移动得来还是向右移动得来的，每次用最大值来加上当前元素(grid[i][j])一直推导到起点
                        dp[i][j] = Math.Max(dp[i + 1][j], dp[i][j + 1]) + grid[i][j];
                    }
                }
            //完成推导以后，起点就是最大值
            return dp[0][0];
        }
    }
}
