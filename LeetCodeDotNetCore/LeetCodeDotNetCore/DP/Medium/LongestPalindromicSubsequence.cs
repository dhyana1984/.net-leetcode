using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    public class LongestPalindromicSubsequence
    {
        public int Solution( string s)
        {
            var n = s.Length;
            if (n == 1) return 1;
            var dp = new int[n][];
            for (var i = 0; i < n; i++)
            {
                dp[i] = new int[n];
            }
            for (var i = 0; i < n; i++)
            {
                dp[i][i] = 1;
            }
            //从结尾循环
            for (var i = n - 1; i >= 0; i--)
                //只遍历矩阵对角线以上
                for (var j = i + 1; j < n; j++)
                {
                    //如果s[i]和s[j]相等，s[i...j]必然是回文字符串，而且长度是s[i+1...j-1]的长度+2
                    if (s[i] == s[j])
                    {
                        dp[i][j] = dp[i + 1][j - 1] + 2;
                    }
                    //如果s[i]和s[j]不相等,此时回文字符串长度dp[i][j]最大应该是s[i...j-1]或者s[i+1...j]中取较大的值
                    else
                    {
                        dp[i][j] = Math.Max(dp[i][j - 1], dp[i + 1][j]);
                    }
                }

            //最后返回第1行的最后一个值是最大的回文字符串长度
            return dp[0][n - 1];
        }
    }
}
