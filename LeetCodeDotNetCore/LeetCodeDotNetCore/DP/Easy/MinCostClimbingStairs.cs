using System;
namespace LeetCodeDotNetCore.DP.Easy
{
    public class MinCostClimbingStairs
    {
        public int Solution(int[] cost)
        {
            if (cost == null || cost.Length == 0) return 0;
            if (cost.Length == 1) return cost[0];
            if (cost.Length == 2) return Math.Min(cost[0], cost[1]);
            var dp = new int[cost.Length];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (var i = 2; i < cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
            }

            return Math.Min(dp[cost.Length - 2], dp[cost.Length - 1]);
        }
    }
}
