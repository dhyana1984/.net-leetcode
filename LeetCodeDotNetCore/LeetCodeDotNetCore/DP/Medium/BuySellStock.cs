using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /*
     * 假设把某股票的价格按照时间先后顺序存储在数组中，请问买卖该股票一次可能获得的最大利润是多少？

    示例 1:

    输入: [7,1,5,3,6,4]
    输出: 5
    解释: 在第 2 天（股票价格 = 1）的时候买入，在第 5 天（股票价格 = 6）的时候卖出，最大利润 = 6-1 = 5 。
         注意利润不能是 7-1 = 6, 因为卖出价格需要大于买入价格。
    示例 2:

    输入: [7,6,4,3,1]
    输出: 0
    解释: 在这种情况下, 没有交易完成, 所以最大利润为 0。
 

    限制：

    0 <= 数组长度 <= 10^5

     */
    public class BuySellStock
    {
        public int Solution(int[] prices)
        {
            if (prices.Length == 0 || prices.Length == 1) return 0;
            var dp = new int[] { 0, 0 };
            //第一天不持有状态，为0
            dp[0] = 0;
            //第一天持有状态，因为买入不能卖，所以为行情第一天的股票价格的负数
            dp[1] = -prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                //不持有，则在昨天也不持有和昨天持有今天卖出两种情况中选较大的
                dp[0] = Math.Max(dp[0], dp[1] + prices[i]);
                //持有，则在昨天也持有和昨天不持有，今天买入持有两种情况中选较大的
                //因为只能交易一次，上面dp[0]里面已经交易过了，所以要用0 - prices[i]而不能用dp[0] -prices[i]
                dp[1] = Math.Max(dp[1], 0 - prices[i]);
            }
            return dp[0];
        }
    }
}
