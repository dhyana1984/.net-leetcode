using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

        示例 1:

        输入: "abcabcbb"
        输出: 3 
        解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
        示例 2:

        输入: "bbbbb"
        输出: 1
        解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
        示例 3:

        输入: "pwwkew"
        输出: 3
        解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
        请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
     
         */
    public class SolutionLengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;
            if (s.Trim() == "")
                return 1;
            if (length == 1)
                return 1;
            if (length == 2 && s[1] != s[0])
                return 2;
            int count = 1;
            string result = "";
            int a_max = 1;
            for (int i = 0; i <length-1; i++)
            {
                if(!result.Contains(s[i]))
                {
                    result += s[i];
                    count++;
                }
                else
                {
                    result = "" + s[i];
                    a_max = Math.Max(count,count);
                    count = 1;
                }
            }

            return a_max;
        }
    }
}
