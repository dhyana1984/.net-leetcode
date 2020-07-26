using System;
namespace LeetCodeDotNetCore.DP.Easy
{
    /*
     * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

        Example:

        Input: [-2,1,-3,4,-1,2,1,-5,4],
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.
        Follow up:

        If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.

     */
    public class MaximumSubarray
    {
        public int Solution(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            var maxSum = nums[0];
            var curSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (curSum>0)           //如果到此的最长子序列和是正数
                {
                    curSum += nums[i];  //继续加上当前元素
                }
                else                    //如果循环到此的最长子集合为非正数
                {
                    curSum = nums[i];   //则赋予最长子集合值为当前元素值
                }
                maxSum = Math.Max(maxSum, curSum); //判断最大的和与当前子和哪个大
            }
            return maxSum;
        }
    }
}
