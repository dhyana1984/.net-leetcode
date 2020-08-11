/**
 * 1262
 * 给你一个整数数组 nums，请你找出并返回能被三整除的元素最大和。



示例 1：

输入：nums = [3,6,5,1,8]
输出：18
解释：选出数字 3, 6, 1 和 8，它们的和是 18（可被 3 整除的最大和）。
示例 2：

输入：nums = [4]
输出：0
解释：4 不能被 3 整除，所以无法选出数字，返回 0。
示例 3：

输入：nums = [1,2,3,4,4]
输出：12
解释：选出数字 1, 3, 4 以及 4，它们的和是 12（可被 3 整除的最大和）。

 */


/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSumDivThree = function (nums) {
    //dp[0],dp[1],dp[2]分别表示被3除后模0，模1，模2的数字的和
    const dp = Array.from({ length: nums.length + 1 }, _ => [0, 0, 0])
    dp[0] = [0, -Infinity, -Infinity]
    for (let i = 1; i <= nums.length; i++) {
        //当当前元素能被3整除时， dp[0],dp[1],dp[2]各自加上当前元素
        if (nums[i - 1] % 3 === 0) {
            dp[i][0] = dp[i - 1][0] + nums[i - 1]
            dp[i][1] = dp[i - 1][1] + nums[i - 1]
            dp[i][2] = dp[i - 1][2] + nums[i - 1]
        //如果当前元素被3整除后模1
        } else if (nums[i - 1] % 3 === 1) {
            //被3整除后模0的和应该在自己和上一个被3整除模2的和加当前元素中选一个较大的，
            //因为上一个被3整除模2加上当前这个被3整除模1的结果被3整除会模0
            dp[i][0] = Math.max(dp[i - 1][0], dp[i - 1][2] + nums[i - 1])
            dp[i][1] = Math.max(dp[i - 1][1], dp[i - 1][0] + nums[i - 1])
            dp[i][2] = Math.max(dp[i - 1][2], dp[i - 1][1] + nums[i - 1])
        } else if (nums[i - 1] % 3 === 2) {
            dp[i][0] = Math.max(dp[i - 1][0], dp[i - 1][1] + nums[i - 1])
            dp[i][1] = Math.max(dp[i - 1][1], dp[i - 1][2] + nums[i - 1])
            dp[i][2] = Math.max(dp[i - 1][2], dp[i - 1][0] + nums[i - 1])
        }
    }

    return dp[nums.length][0]

};