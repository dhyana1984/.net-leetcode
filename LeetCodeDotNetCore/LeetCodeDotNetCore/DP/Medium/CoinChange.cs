using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    public class CoinChange
    {
        public int Solution(int[] coins, int amount)
        {
            if (amount == 0) return 0;

            //初始化数组，初始值为amount+1
            //初始值取11的目的是认为当前dp的结果是不存在，即返回-1
            var dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);

            //金额遍历
            for (var i = 0; i < amount + 1; i++)
                //不同面额的钞票遍历
                for (var j = 0; j < coins.Length; j++)
                {
                    //如果当前所选的钞票面额要大于当前金额，直接跳过
                    if (coins[j] > i) continue;
                    //如果当前所选的钞票面额要不大于当前金额，有两种选择
                    //用掉当前面额钞票，并且将用掉的钞票数量+1，或者不用钞票
                    //取其中较小的钞票使用数量
                    dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                }

            return dp[amount] == amount + 1 ? -1 : dp[amount];
        }
    }
}
