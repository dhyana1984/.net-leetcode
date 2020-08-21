/*
 * 统计一个数字在排序数组中出现的次数。



示例 1:

输入: nums = [5,7,7,8,8,10], target = 8
输出: 2
示例 2:

输入: nums = [5,7,7,8,8,10], target = 6
输出: 0


 */

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
let res = 0
var search = function (nums, target) {
    // 搜索右边界 right
    let i = 0, j = nums.length - 1
    while (i <= j) {
        m = (i + j) // 2
        if (nums[m] <= target) {
            i = m + 1
        }
        else {
            j = m - 1
        }
    }
    right = i
    // 若数组中无 target ，则提前返回
    if (j >= 0 && nums[j] != target) return 0
    // 搜索左边界 left
    i = 0
    while (i <= j) {
        m = (i + j) // 2
        if (nums[m] < target) {
            i = m + 1
        }
        else {
            j = m - 1
        }
    }
    left = j
    return right - left - 1

};