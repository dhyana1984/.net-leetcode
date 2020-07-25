using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy.DP
{
    /*
     * 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。

        如果你最多只允许完成一笔交易（即买入和卖出一支股票），设计一个算法来计算你所能获取的最大利润。

        注意你不能在买入股票前卖出股票。

        示例 1:

        输入: [7,1,5,3,6,4]
        输出: 5
        解释: 在第 2 天（股票价格 = 1）的时候买入，在第 5 天（股票价格 = 6）的时候卖出，最大利润 = 6-1 = 5 。
             注意利润不能是 7-1 = 6, 因为卖出价格需要大于买入价格。
        示例 2:

        输入: [7,6,4,3,1]
        输出: 0
        解释: 在这种情况下, 没有交易完成, 所以最大利润为 0。


     */
    public class StockMaxProfit
    {
        public int Solution(int[] prices)
        {
            /*
             * 设第i天的股票价格是p(i)
             * 截止第i天最低股价是min(p(i),min(i-1))，其中min(i-1)=min(p(i-1),min(i-2))
             * 那么截止第i天最大收益是max(max(i-1),p(i)-min(i-1))，此为dp方程
             */
            if (prices.Length == 1 || prices.Length == 0)
                return 0;
            int min = prices[0];                        //截止第1天的最小股价就是第一天的股价
            int max = 0;                                //截止第一天的最大收益是0，因为第一天还没有交易
            for (int i = 1; i < prices.Length; i++)     //从第二天开始计算收益
            {
                min = Math.Min(prices[i], min);         //截止第i天的最低股价
                max = Math.Max(max, prices[i] - min);   //截止第i天的最大收益
            }

            return max;


        }
    }
}

