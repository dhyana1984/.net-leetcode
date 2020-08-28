/*
给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的 连续 子数组，并返回其长度。如果不存在符合条件的子数组，返回 0。



示例：

输入：s = 7, nums = [2,3,1,2,4,3]
输出：2
解释：子数组 [4,3] 是该条件下的长度最小的子数组。


 */

/**
 * @param {number} s
 * @param {number[]} nums
 * @return {number}
 */
var minSubArrayLen = function (s, nums) {
    const n = nums.length
    if (n === 0) return 0
    if (nums[0] >= s) return 1
    let start = 0, end = 0, res = Infinity, sum = 0
    while (end < n) {
        sum += nums[end]
        while (sum >= s) {
            res = Math.min(res, end - start + 1)
            sum -= nums[start]
            start++
        }
        end++
    }

    return res === Infinity ? 0 : res
};