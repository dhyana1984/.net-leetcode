using System;
namespace LeetCodeDotNetCore.DP.Easy
{
    /*
     * A child is running up a staircase with n steps and can hop either 1 step, 2 steps, or 3 steps at a time. Implement a method to count how many possible ways the child can run up the stairs. The result may be large, so return it modulo 1000000007.

        Example1:

         Input: n = 3 
         Output: 4
        Example2:

         Input: n = 5
         Output: 13
        Note:

        1 <= n <= 1000000

     */
    public class ThreeStepsProblem
    {
        public int Solution(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 4;
            var dp = new long[n];
            dp[0] = 1;
            dp[1] = 2;
            dp[2] = 4;
            for (var i = 3; i < n; i++)
            {
                //状态转移方程
                //例如如果有1层台阶，有1种跳法，有两层台阶，有2种跳法，有3层台阶有4种跳法
                //如果加到4层台阶，那么总共的跳法是1层台阶的跳法+2层台阶的跳法+3层台阶的跳法
                //所以dp[i] = dp[i-3] + dp[i-2] + dp[i-1]
                dp[i] = (dp[i - 3] + dp[i - 2] + dp[i - 1]) % 1000000007;
            }
            return (int)dp[n - 1];
        }
    }
}
