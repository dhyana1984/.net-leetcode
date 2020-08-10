
/* 309
    给定一个整数数组，其中第 i 个元素代表了第 i 天的股票价格 。

    设计一个算法计算出最大利润。在满足以下约束条件下，你可以尽可能地完成更多的交易（多次买卖一支股票）:

    你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）。
    卖出股票后，你无法在第二天买入股票 (即冷冻期为 1 天)。
    示例:

    输入: [1,2,3,0,2]
    输出: 3
    解释: 对应的交易状态为: [买入, 卖出, 冷冻期, 买入, 卖出]
*/

/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    if(prices.length<=1) return 0
    //dp[0]是不持有状态，dp[1]是持有状态，第一天如果持有要减去第一天的股票价格，即-prices[0]
    const dp = [0, -prices[0]]
    let flag = false
    //pre代表前一天的dp[0]值，也就是前一天不持有的最大收益
    let pre = 0
    for(let i =1; i<prices.length; i++){
        //先把前一天dp[0]保存起来
        const temp = dp[0]
        //如果当天不持有，那么从昨天不持有以及昨天持有今天卖掉两个结果中选取较大的，作为今天不持有的值
        dp[0] = Math.max(dp[0], dp[1]+prices[i])       
        //如果当天持有，那么从昨天持有以及当天不交易，前一天的不持有的最大收益值减去当天股票价格
        dp[1] = Math.max(dp[1], pre-prices[i] )
        //保存当天不持有的最大收益
        pre = temp
    }
    return dp[0]

};

