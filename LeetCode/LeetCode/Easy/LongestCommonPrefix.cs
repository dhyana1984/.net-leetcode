using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*编写一个函数来查找字符串数组中的最长公共前缀。

        如果不存在公共前缀，返回空字符串 ""。

        示例 1:

        输入: ["flower","flow","flight"]
        输出: "fl"
        示例 2:

        输入: ["dog","racecar","car"]
        输出: ""
        解释: 输入不存在公共前缀。
        说明:

        所有输入只包含小写字母 a-z 。
         */
    public class SolutionLongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];
            string minStr = strs.Min();
            string result = "";
            List<string> list = strs.ToList();
            list.Remove(minStr);
            bool flag = true;
            for (int i = 0; i < minStr.Length; i++)
            {
                
                foreach (var item in list)
                {
                    if (item.Substring(0, i + 1) != minStr.Substring(0,i+1))
                    {
                        flag = false;
                        break;
                    }
                   
                }
                if(!flag)
                {
                    break;
                }
                result = minStr.Substring(0, i + 1);

            }

            return result;
        }
    }
}

