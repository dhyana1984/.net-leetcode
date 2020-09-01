
/**
 * 
给定一个按照升序排列的整数数组 nums，和一个目标值 target。找出给定目标值在数组中的开始位置和结束位置。

你的算法时间复杂度必须是 O(log n) 级别。

如果数组中不存在目标值，返回 [-1, -1]。

示例 1:

输入: nums = [5,7,7,8,8,10], target = 8
输出: [3,4]
示例 2:

输入: nums = [5,7,7,8,8,10], target = 6
输出: [-1,-1]

 */

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 * //搜索左右边界模板
 */
var searchRange = function (nums, target) {
    if (!nums.length) return [-1, -1]
    let l = 0, r = nums.length - 1
    //搜target的左边界
    while (l < r) {
        //向下取整为了拿左边界
        const mid = Math.floor((l + r) / 2)
        if (target <= nums[mid]) {
            r = mid
        } else {
            l = mid + 1
        }
    }
    if (nums[l] !== target) return [-1, -1]
    const start = l
    l = 0
    r = nums.length - 1
    //搜target右边界
    while (l < r) {
        //向上取整为了拿右边界
        const mid = Math.ceil((l + r) / 2)
        if (target >= nums[mid]) {
            l = mid
        } else {
            r = mid - 1
        }
    }
    if (nums[r] !== target) return [-1, -1]
    const end = r
    return [start, end]


};