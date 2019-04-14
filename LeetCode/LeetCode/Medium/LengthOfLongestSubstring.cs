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
            
            int ans = 0,i= 0,j = 0;
            /*滑动窗口是数组/字符串问题中常用的抽象概念。 
             * 窗口通常是在数组/字符串中由开始和结束索引定义的一系列元素的集合，即 [i, j)[i,j)（左闭，右开）。
             * 而滑动窗口是可以将两个边界向某一方向“滑动”的窗口。
             * 例如，我们将 [i, j)[i,j) 向右滑动 11 个元素，则它将变为 [i+1, j+1)[i+1,j+1)（左闭，右开）。
             */

            /* 使用 HashSet 将字符存储在当前窗口 [i, j)（最初 j = i）中。 
             * 然后向右侧滑动索引 j，如果它不在 HashSet 中，我们会继续滑动 j。
             * 直到 s[j] 已经存在于 HashSet 中。
             * 此时，找到的没有重复字符的最长子字符串将会以索引 i 开头。如果对所有的 i 这样做，就可以得到答案。
             */
            //HashSet<char> set = new HashSet<char>();
            //while (i < length && j<length)
            //{
            //    if(!set.Contains(s[j]))
            //    {
            //        set.Add(s[j]);
            //        j++;
            //        ans = Math.Max(ans, j-i);
            //    }
            //    else
            //    {
            //        set.Remove(s[j]);
            //        i++;
            //    }
            //}
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (i = 0,j=0; j < length; j++)
            {
                if(dict.ContainsKey(s[j]))
                {
                    i = Math.Max(dict[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);
                dict[s[j]] = j + 1;

            }
            return ans;
 
        }
    }
}
