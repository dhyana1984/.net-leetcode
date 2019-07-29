using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
    /*
     * 给定一个平衡括号字符串 S，按下述规则计算该字符串的分数：

    () 得 1 分。
    AB 得 A + B 分，其中 A 和 B 是平衡括号字符串。
    (A) 得 2 * A 分，其中 A 是平衡括号字符串。
 

    示例 1：

    输入： "()"
    输出： 1
    示例 2：

    输入： "(())"
    输出： 2
    示例 3：

    输入： "()()"
    输出： 2
    示例 4：

    输入： "(()(()))"
    输出： 6
 

    提示：

    S 是平衡括号字符串，且只含有 ( 和 ) 。
    2 <= S.length <= 50


     */

    public class ScoreOfParentheses
    {
        public int Solution(string S)
        {
            var res = 0;
            var param = 0;
            var stack = new Stack<char>();
            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    stack.Push(S[i]);
                    param = (int)Math.Pow(2, stack.Count - 1);
                }
                else if (stack.Any())
                {
                    stack.Pop();
                    res += param;
                    param = 0;
                }
            }
            return res;
        }
    }
}
