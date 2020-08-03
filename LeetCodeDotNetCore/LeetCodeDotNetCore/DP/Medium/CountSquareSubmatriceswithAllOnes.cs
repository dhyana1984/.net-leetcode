using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    public class CountSquareSubmatriceswithAllOnes
    {
        /*
         * 给你一个 m * n 的矩阵，矩阵中的元素不是 0 就是 1，请你统计并返回其中完全由 1 组成的 正方形 子矩阵的个数。

        示例 1：

        输入：matrix =
        [
          [0,1,1,1],
          [1,1,1,1],
          [0,1,1,1]
        ]
        输出：15
        解释： 
        边长为 1 的正方形有 10 个。
        边长为 2 的正方形有 4 个。
        边长为 3 的正方形有 1 个。
        正方形的总数 = 10 + 4 + 1 = 15.

         */
        public int Solution(int[][] matrix)
        {
            var m = matrix.Length;
            if (m == 0) return 0;
            var n = matrix[0].Length;

            var dp = new int[m + 1][];
            for (var i = 0; i < m + 1; i++)
            {
                dp[i] = new int[n + 1];
            }
            var res = 0;
            for (var i = 0; i < m; i++)
                for (var j = 0; j < n; j++)
                {
                    //如果矩阵的值等于1
                    if (matrix[i][j] == 1)
                    {
                        //matrix[i][j]此时组成的正方形的边长应该是
                        //左边组成正方形最大边长
                        //上边组成正方形最大边长
                        //左上边组成正方形最大边长
                        //其中最小的值，短板原理
                        dp[i + 1][j + 1] = Math.Min(dp[i + 1][j], dp[i][j + 1]);
                        dp[i + 1][j + 1] = Math.Min(dp[i][j], dp[i + 1][j + 1]) + 1;
                        //记录下来可以组成多少个正方形
                        res += dp[i + 1][j + 1];
                    }
                }
            return res;
        }
    }
}
