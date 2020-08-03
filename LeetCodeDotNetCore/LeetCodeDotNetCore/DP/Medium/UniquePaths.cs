using System;
using System.Collections;

namespace LeetCodeDotNetCore.DP.Medium
{
    /*62
     * 一个机器人位于一个 m x n 网格的左上角 （起始点在下图中标记为“Start” ）。

        机器人每次只能向下或者向右移动一步。机器人试图达到网格的右下角（在下图中标记为“Finish”）。

        问总共有多少条不同的路径？

     */
    public class UniquePaths
    {
        public int Solution(int m, int n)
        {
            //边界情况，如果只有一行或者一列，必定只有一条路径
            if (m == 1 || n == 1) return 1;
            var dp = new int[m][];
            for (var i = m - 1; i >= 0; i--)
            {
                dp[i] = new int[n];
            }
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    //如果是第一行，每一格都只会是同一种路径走到的，即向右走，所以路径数都是1
                    if (i == 0)
                    {
                        dp[i][j] = 1;
                    }
                    //如果是第一列，每一格也只会是同一种路径走到的，即向下走，所以路径数都是1
                    else if (j == 0)
                    {
                        dp[i][j] = 1;
                    }
                    //如果不是第一行或者第一列，则可能走到此格子的路径是左边格子的路径数加上上边格子的路径数
                    else
                    {
                        dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                    }
                }
            }
            //终点的路径数就是最终的路径总和
            return dp[m - 1][n - 1];
        }
    }
}
