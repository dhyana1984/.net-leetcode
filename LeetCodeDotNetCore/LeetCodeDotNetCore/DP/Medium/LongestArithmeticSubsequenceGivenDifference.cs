﻿using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /*
     * 给你一个整数数组 arr 和一个整数 difference，请你找出 arr 中所有相邻元素之间的差等于给定 difference 的等差子序列，并返回其中最长的等差子序列的长度。

 

        示例 1：

        输入：arr = [1,2,3,4], difference = 1
        输出：4
        解释：最长的等差子序列是 [1,2,3,4]。
        示例 2：

        输入：arr = [1,3,5,7], difference = 1
        输出：1
        解释：最长的等差子序列是任意单个元素。
        示例 3：

        输入：arr = [1,5,7,8,5,3,4,2,1], difference = -2
        输出：4
        解释：最长的等差子序列是 [7,5,3,1]。
 

        提示：

        1 <= arr.length <= 10^5
        -10^4 <= arr[i], difference <= 10^4

     */
    public class LongestArithmeticSubsequenceGivenDifference
    {
        public int Solution(int[] arr, int difference)
        {
            if (arr.Length == 1) return 1;
            if (arr.Length == 2) return arr[1] - arr[0] == difference ? 2 : 1;

            var dp = new int[50000];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] += 10000;
            }
            var res = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var sum = arr[i] - difference;
                if (sum < 0 || sum > 20000)
                {
                    dp[arr[i]] = 1;
                }
                else
                {
                    dp[arr[i]] = Math.Max(dp[arr[i]], dp[sum] + 1);
                }
                res = Math.Max(res, dp[arr[i]]);
            }
            return res;
        }
    }
}
