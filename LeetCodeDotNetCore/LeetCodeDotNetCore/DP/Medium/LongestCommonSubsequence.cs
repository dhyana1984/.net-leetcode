using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /*
     * 给定两个字符串 text1 和 text2，返回这两个字符串的最长公共子序列的长度。

        一个字符串的 子序列 是指这样一个新的字符串：它是由原字符串在不改变字符的相对顺序的情况下删除某些字符（也可以不删除任何字符）后组成的新字符串。
        例如，"ace" 是 "abcde" 的子序列，但 "aec" 不是 "abcde" 的子序列。两个字符串的「公共子序列」是这两个字符串所共同拥有的子序列。

        若这两个字符串没有公共子序列，则返回 0。

 

        示例 1:

        输入：text1 = "abcde", text2 = "ace" 
        输出：3  
        解释：最长公共子序列是 "ace"，它的长度为 3。
        示例 2:

        输入：text1 = "abc", text2 = "abc"
        输出：3
        解释：最长公共子序列是 "abc"，它的长度为 3。
        示例 3:

        输入：text1 = "abc", text2 = "def"
        输出：0
        解释：两个字符串没有公共子序列，返回 0。
 

        提示:

        1 <= text1.length <= 1000
        1 <= text2.length <= 1000
        输入的字符串只含有小写英文字符。
        通过次数34,004提交次数56,466
。
     */
    public class LongestCommonSubsequence
    {
        public int Solution(string text1, string text2)
        {
            //定义dp table，dp[0][j]和dp[i][0]都是0，表示base case
            var dp = new int[text1.Length + 1][];
            for (var i = 0; i <= text1.Length; i++)
            {
                dp[i] = new int[text2.Length + 1];
            }
            //遍历从dp[1][1]开始
            for (var i = 1; i <= text1.Length; i++)
                for (var j = 1; j <= text2.Length; j++)
                {
                    //如果此时text1前一个遍历到的字符和text2前一个遍历到的字符相同
                    if (text1[i - 1] == text2[j - 1])
                    {
                        //此时dp值等于上一个字符相等的字符公共字符串长度值+1
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                    }
                    //如果此时text1前一个遍历到的字符和text2前一个遍历到的字符不相同
                    else
                    {
                        //获取text1的到i-1个字符与text2的到第j个字符的最大公共字符串长度
                        //获取text2的到j-1个字符与text1的到第i个字符的最大公共字符串长度
                        //比较两者，取较大的
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                    }
                }

            return dp[text1.Length][text2.Length];
        }
    }
}
