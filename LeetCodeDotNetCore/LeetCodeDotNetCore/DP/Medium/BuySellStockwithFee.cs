using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /* 714
     * Your are given an array of integers prices, for which the i-th element is the price of a given stock on day i; and a non-negative integer fee representing a transaction fee.

        You may complete as many transactions as you like, but you need to pay the transaction fee for each transaction. You may not buy more than 1 share of a stock at a time (ie. you must sell the stock share before you buy again.)

        Return the maximum profit you can make.

        Example 1:
        Input: prices = [1, 3, 2, 8, 4, 9], fee = 2
        Output: 8
        Explanation: The maximum profit can be achieved by:
        Buying at prices[0] = 1
        Selling at prices[3] = 8
        Buying at prices[4] = 4
        Selling at prices[5] = 9
        The total profit is ((8 - 1) - 2) + ((9 - 4) - 2) = 8.
     */
    public class BuySellStockwithFee
    {
        public int Solution(int[] prices, int fee)
        {
            //两种状态，持股或者不持股
            var dp = new int[] { 0, 0 };
            //当只有一天行情时，不持股利润就是0
            dp[0] = 0;
            //持股卖不了，所以是负prices[0]。这里持股不能卖，所以不用扣fee
            dp[1] = -prices[0];
            //从第二天行情开始遍历
            for (var i = 1; i < prices.Length; i++)
            {
                //如果不持股，可能是昨天也没持股，或者昨天持股今天卖掉了，所以需要加上股票价格并且减去fee
                dp[0] = Math.Max(dp[0], dp[1] + prices[i] - fee);
                //如果持股，可能是昨天也持股，或者昨天不持股，今天买了，所以要减去股票价格，但是还没卖，所以不用减去fee
                dp[1] = Math.Max(dp[1], dp[0] - prices[i]);
            }
            //最终获取不持股的价值，因为最后一步一定会卖掉
            return dp[0];
        }
    }
}
