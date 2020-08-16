using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeDotNetCore
{
    public class KeyboardRow
    {
        /*500
         * 给定一个单词列表，只返回可以使用在键盘同一行的字母打印出来的单词
         * 
         * 输入: ["Hello", "Alaska", "Dad", "Peace"]
           输出: ["Alaska", "Dad"]
         */
        public string[] Solution(string[] words)
        {

            //初始化
            var list = new List<string>
            {
                "qwertyuiop",
                "asdfghjkl",
                "zxcvbnm"
            };
            var res = new List<string>();
            //遍历每个单词
            foreach (var word in words)
            {
                //pre指上个字母在哪个list
                var pre = 0;
                var flag = true;
                //注意这里换成小写
                var chars = word.ToLower().ToCharArray();
                //遍历单词的每个字母
                for (var j = 0; j < chars.Count(); j++)
                {
                    //cur指当前字母在哪个list
                    var cur = 0;
                    //当前字母在哪个list就将cur存成几
                    if (list[0].Contains(chars[j]))
                    {
                        cur = 0;
                    }
                    else if (list[1].Contains(chars[j]))
                    {
                        cur = 1;
                    }
                    else if (list[2].Contains(chars[j]))
                    {
                        cur = 2;
                    }
                    //如果不是第一个字母，比对当前字母的list和上一个字母的list是不是同一个list
                    if (j != 0 && pre != cur)
                    {
                        //如果不是的话将false赋给标志位，不用存这个单词，并且break当前单词的字母遍历
                        flag = false;
                        break;
                    }
                    //如果是第一个字母，那么把第一个字母所在的list索引给pre
                    else
                    {
                        pre = cur;
                    }

                }
                //如果所有字母都在同一个list，则保存该单词
                if (flag)
                {
                    res.Add(word);
                }
            }
            return res.ToArray();
        }
    }
}
