/*
 * 给定一个无序的整数数组，找到其中最长上升子序列的长度。

示例:

输入: [10,9,2,5,3,7,101,18]
输出: 4
解释: 最长的上升子序列是 [2,3,7,101]，它的长度是 4。
说明:

可能会有多种最长上升子序列的组合，你只需要输出对应的长度即可。
你算法的时间复杂度应该为 O(n2) 。

 */

/**
 * @param {number[]} nums
 * @return {number}
 */
var lengthOfLIS = function (nums) {
    const n = nums.length
    if (n === 0) return 0
    const dp = Array.from({ length: nums.length }, _ => 1)
    let res = 1
    for (let i = 1; i < n; i++)
        for (let j = 0; j < i; j++) {
            if (nums[i] > nums[j]) dp[i] = Math.max(dp[i], dp[j] + 1)
            res = Math.max(res, dp[i])
        }
    return res

};