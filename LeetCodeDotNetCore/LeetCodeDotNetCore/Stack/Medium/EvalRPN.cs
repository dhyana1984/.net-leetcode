using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
    /*
     * 根据逆波兰表示法，求表达式的值。

    有效的运算符包括 +, -, *, / 。每个运算对象可以是整数，也可以是另一个逆波兰表达式。

    说明：

    整数除法只保留整数部分。
    给定逆波兰表达式总是有效的。换句话说，表达式总会得出有效数值且不存在除数为 0 的情况。
    示例 1：

    输入: ["2", "1", "+", "3", "*"]
    输出: 9
    解释: ((2 + 1) * 3) = 9
    示例 2：

    输入: ["4", "13", "5", "/", "+"]
    输出: 6
    解释: (4 + (13 / 5)) = 6
    示例 3：

    输入: ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]
    输出: 22
    解释: 
      ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
    = ((10 * (6 / (12 * -11))) + 17) + 5
    = ((10 * (6 / -132)) + 17) + 5
    = ((10 * 0) + 17) + 5
    = (0 + 17) + 5
    = 17 + 5
    = 22

     */

    public class EvalRPN
    {
        public int Solution(string[] tokens)
        {
            var stack = new Stack<string>();
            var symbol = new string[] { "+", "-", "*", "/" };
            DataTable dt = new DataTable();
            for (var i = 0; i < tokens.Length; i++)
            {
                if (symbol.Contains(tokens[i]))
                {
                    var a = stack.Pop();
                    var b = stack.Pop();
  
                    var formula = b + tokens[i] + a;
                    var result = dt.Compute(formula, "false").ToString();
                    stack.Push(Math.Truncate(decimal.Parse(result)).ToString());
                }
                else
                    stack.Push(tokens[i]);
            }

            return int.Parse(stack.Peek());
        }
    }
}
