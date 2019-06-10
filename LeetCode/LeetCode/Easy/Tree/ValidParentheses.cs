using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

        有效字符串需满足：

        左括号必须用相同类型的右括号闭合。
        左括号必须以正确的顺序闭合。
        注意空字符串可被认为是有效字符串。

        示例 1:

        输入: "()"
        输出: true
        示例 2:

        输入: "()[]{}"
        输出: true
        示例 3:

        输入: "(]"
        输出: false
        示例 4:

        输入: "([)]"
        输出: false
        示例 5:

        输入: "{[]}"
        输出: true
     */
    public class SolutionValidParentheses
    {
        public bool IsValidParentheses(string s)
        {
            //s = s.Replace(" ", "");
            //while(s.Contains("()")|| s.Contains("[]")|| s.Contains("{}"))
            //{
            //    s=s.Replace("()", "");
            //    s=s.Replace("[]", "");
            //    s=s.Replace("{}", "");
            //}

            //return s == "";
            
            Dictionary<char,char> dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['['] = ']';
            dict['{'] = '}';

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                
                char c = s[i];
                if(dict.ContainsKey(c))
                {
                    //如果当前字符是左括号，则入栈
                    stack.Push(c);

                }
                else
                {
                    if(stack.Count>0)
                    { 
                        //如果当前栈内有左括号，和当前字符比较是否是匹配的右括号，并弹出当前左括号
                        char popChar = stack.Pop();
                        //如果当前的字符不是栈内左括号匹配的右括号，则返回false
                        if(c != ' '&&dict[popChar]!=c)
                        {
                            return false;
                        }
                    }
                    else if(c!=' ')
                    {
                        //如果当前字符不是左括号而是右括号，并且栈内是空的，直接返回false
                        return false;
                    }
                }
            }

            //最后判断栈内是否清空
            return stack.Count == 0;

        }
    }
}

