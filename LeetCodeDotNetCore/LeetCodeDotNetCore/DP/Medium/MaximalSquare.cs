using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /*221
     * Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

        Example:

        Input: 

        1 0 1 0 0
        1 0 1 1 1
        1 1 1 1 1
        1 0 0 1 0

        Output: 4

     */
    public class MaximalSquare
    {
        public int Solution(char[][] matrix)
        {
            var row = matrix.Length;
            if (row == 0) return 0;

            var col = matrix[0].Length;
            var dp = new int[row + 1][];
            for (var i = 0; i < row + 1; i++)
            {
                dp[i] = new int[col + 1];
            }
            var max = 0;
            for (var i = 0; i < row; i++)
                for (var j = 0; j < col; j++)
                {
                    //如果当前矩阵的值是1
                    if (matrix[i][j] == '1')
                    {
                        //搜索当前矩阵位置的左边，上边，左上边那一个值的最大正方形边长的值最小，
                        //因为当前值的最大边长取决于左，上 ，左上的最大正方形边长的最小值
                        //最后还要加上1，即本身
                        dp[i + 1][j + 1] = Math.Min(dp[i + 1][j], dp[i][j + 1]);
                        dp[i + 1][j + 1] = Math.Min(dp[i + 1][j + 1], dp[i][j]) + 1;

                        //记录出现过的所有矩阵值是1的组成的最大正方形边长的边，取最大值
                        max = Math.Max(max, dp[i + 1][j + 1]);
                    }
                }
            //返回面积
            return max * max;
        }
    }
}
