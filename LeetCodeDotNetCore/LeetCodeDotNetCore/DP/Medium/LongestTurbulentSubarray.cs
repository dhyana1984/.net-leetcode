using System;
using System.Linq;

namespace LeetCodeDotNetCore.DP.Medium
{
    /*978
     * 当 A 的子数组 A[i], A[i+1], ..., A[j] 满足下列条件时，我们称其为湍流子数组：

        若 i <= k < j，当 k 为奇数时， A[k] > A[k+1]，且当 k 为偶数时，A[k] < A[k+1]；
        或 若 i <= k < j，当 k 为偶数时，A[k] > A[k+1] ，且当 k 为奇数时， A[k] < A[k+1]。
        也就是说，如果比较符号在子数组中的每个相邻元素对之间翻转，则该子数组是湍流子数组。

        返回 A 的最大湍流子数组的长度。

 

        示例 1：

        输入：[9,4,2,10,7,8,8,1,9]
        输出：5
        解释：(A[1] > A[2] < A[3] > A[4] < A[5])

     */
    public class LongestTurbulentSubarray
    {
        public int Solution(int[] A)
        {
            if (A.Length == 1 || A.Max() == A.Min()) return 1;

            var dp = new int[A.Length];
            dp[0] = 1;
            for (var i = 1; i < A.Length - 1; i++)
            {
                //如果当前元素小于两边或者大于两边，则加上前一个元素的最大湍流长度
                if ((A[i] > A[i - 1] && A[i] > A[i + 1]) || (A[i] < A[i - 1] && A[i] < A[i + 1]))
                {
                    dp[i] = dp[i - 1] + 1;
                }
                //否则就等于1
                else
                {
                    dp[i] = 1;
                }
            }
            //返回最大湍流长度+1，要加上最后一个元素本身
            return dp.Max() + 1;
        }
    }
}
