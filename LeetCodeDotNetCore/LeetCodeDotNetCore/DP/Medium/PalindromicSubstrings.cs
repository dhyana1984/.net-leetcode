using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /*
     * 给定一个字符串，你的任务是计算这个字符串中有多少个回文子串。

        具有不同开始位置或结束位置的子串，即使是由相同的字符组成，也会被计为是不同的子串。

        示例 1:

        输入: "abc"
        输出: 3
        解释: 三个回文子串: "a", "b", "c".
        示例 2:

        输入: "aaa"
        输出: 6
        说明: 6个回文子串: "a", "a", "a", "aa", "aa", "aaa".
        注意:

        输入的字符串长度不会超过1000。

     */
    public class PalindromicSubstrings
    {
        public int Solution(string s)
        {
            if (s == null || s == "")
            {
                return 0;
            }
            var n = s.Length;
            var dp = new bool[n][];
            var res = n;
            //定义回文字符串矩阵
            for (var i = 0; i < n; i++)
            {
                dp[i] = new bool[n];
            }
            //初始化矩阵，让对角线全部为true，即每个字母都是一个单独的回文字符串
            for (var i = 0; i < n; i++)
            {
                dp[i][i] = true;
            }
            //从右下角开始遍历，目的是只用遍历对角线以上部分
            for (var i = n - 1; i >= 0; i--)
                //从左向右遍历
                for (var j = i + 1; j < n; j++)
                {
                    //如果此时矩阵纵列值相等
                    if (s[i] == s[j])
                    {
                        //如果此时是相邻的两个字符
                        if (j - i == 1)
                        {
                            //一定是回文字符串
                            dp[i][j] = true;
                        }
                        //如果字符不相邻
                        else
                        {
                            //dp方程
                            //是不是回文字符串取决于左下角的值
                            //实际上就是，如果s[i]==s[j] 只要dp[i+1][j-1]确定是回文，则dp[i][j]一定是回文
                            //体现在字符串上就是，确定到了某两个对称字符是回文，那么这两个字符如果左边和右边的字符相等，那么加上左边的字符加上右边字符一定也是回文
                            dp[i][j] = dp[i + 1][j - 1];
                        }
                    }
                    //如果矩阵纵列不相等则绝对不是回文字符串
                    else
                    {
                        dp[i][j] = false;
                    }
                    if (dp[i][j])
                    {
                        res++;
                    }
                }
            return res;
        }
    }
}
