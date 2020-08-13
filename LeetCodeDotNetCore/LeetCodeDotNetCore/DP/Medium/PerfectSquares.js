/**
 * 279
 * 给定正整数 n，找到若干个完全平方数（比如 1, 4, 9, 16, ...）使得它们的和等于 n。你需要让组成和的完全平方数的个数最少。

示例 1:

输入: n = 12
输出: 3
解释: 12 = 4 + 4 + 4.
示例 2:

输入: n = 13
输出: 2
解释: 13 = 4 + 9.

 */

/**
 * @param {number} n
 * @return {number}
 */
var numSquares = function (n) {

    //dp[i]表示组成i需要的最少完全平方数的个数
    const dp = Array.from({ length: n + 1 }, _ => 0)

    for (i = 1; i <= n; i++) {
        //最大的结果，dp[i]就是由i个1组成
        dp[i] = i
        //循环i以内的完全平方数，即平方小于i的数
        for (k = 1; k * k <= i; k++) {
            //取最小的，组成i的完全平方数的个数
            //由于i = k*k + T，所以dp[i] = min(dp[i], dp[i- k * k]+ 1)
            //dp[i]就是最坏结果，即全部是1组成i,dp[i- k * k]是缺k * k这个完全平方数组成上一个i的最小完全平方数个数，+ 1 就是组成dp[i]的完全平方数个数
            dp[i] = Math.min(dp[i], dp[i - k * k] + 1)
        }
    }
    return dp[n]

};