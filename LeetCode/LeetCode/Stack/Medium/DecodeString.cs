using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{

    public class DecodeString
    {
        /*
         * 给定一个经过编码的字符串，返回它解码后的字符串。

        编码规则为: k[encoded_string]，表示其中方括号内部的 encoded_string 正好重复 k 次。注意 k 保证为正整数。

        你可以认为输入字符串总是有效的；输入字符串中没有额外的空格，且输入的方括号总是符合格式要求的。

        此外，你可以认为原始数据不包含数字，所有的数字只表示重复的次数 k ，例如不会出现像 3a 或 2[4] 的输入。

        示例:

        s = "3[a]2[bc]", 返回 "aaabcbc".
        s = "3[a2[c]]", 返回 "accaccacc".
        s = "2[abc]3[cd]ef", 返回 "abcabccdcdcdef".


         */
        public string Solution(string s)
        {
            if (!s.Contains("["))
                return s;
            var str = "";
            var braketFlag = 0;
            var time = "";
            var tempStr = "";

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    braketFlag -= 1;                        //封闭括号，括号信号减1
                }
                if (braketFlag != 0)
                    tempStr += s[i].ToString();             //括号开启以后，保存括号内的内容
                if (s[i] == '[')
                {
                    braketFlag += 1;                          //开启括号，括号信号加1
                    if (braketFlag == 1)                    //开一层括号时，处理里面的内容，以便于递归
                    {
                        var j = i - 1;                        //前一个字符的索引，也就是数字最后一位
                        time = "";                          //把数字置空，这一步很重要，每一步当前递归里都要置空
                        while (j >= 0)
                        {

                            time = s[j] + time;             //向前取索引，获得完整数字
                            j -= 1;
                            if (j >= 0 && !char.IsDigit(s[j]))  //如果当前索引字符不是数字了，直接跳出取数字的循环
                                break;
                        }
                    }
                }
                if (braketFlag == 0 && char.IsLetter(s[i]))     //括号没有开启时，加上当前的字符，例如"2[abc]3[cd]ef"的ef
                    str += s[i].ToString();

                if (s[i] == ']' && braketFlag == 0)               //当前递归里面的最外层括号封闭，开始进行递归
                {
                    for (var j = 0; j < int.Parse(time); j++)  //通过拿到的数字，进行循环赋值
                        str += Solution(tempStr);           //赋值的内容就是外层括号内的内容，对该内容进行递归
                    tempStr = "";                               //递归完成后把当前临时取递归内容的变量置空，以便于下次递归
                }
            }
            return str;


        }
    }
}
