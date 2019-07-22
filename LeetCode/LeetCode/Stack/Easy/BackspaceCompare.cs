using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Easy
{
    /*
     * 给定 S 和 T 两个字符串，当它们分别被输入到空白的文本编辑器后，判断二者是否相等，并返回结果。 # 代表退格字符。

 

        示例 1：

        输入：S = "ab#c", T = "ad#c"
        输出：true
        解释：S 和 T 都会变成 “ac”。
        示例 2：

        输入：S = "ab##", T = "c#d#"
        输出：true
        解释：S 和 T 都会变成 “”。
        示例 3：

        输入：S = "a##c", T = "#a#c"
        输出：true
        解释：S 和 T 都会变成 “c”。
        示例 4：

        输入：S = "a#c", T = "b"
        输出：false
        解释：S 会变成 “c”，但 T 仍然是 “b”。
 

        提示：

        1 <= S.length <= 200
        1 <= T.length <= 200
        S 和 T 只含有小写字母以及字符 '#'。


     */

    public class BackspaceCompare
    {
        public bool Solution(string S, string T)
        {
            var stack1 = new Stack<char>();
            var stack2 = new Stack<char>();

            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] != '#')
                    stack1.Push(S[i]);
                else if (stack1.Any())
                    stack1.Pop();
            }

            for (var i = 0; i < T.Length; i++)
            {
                if (T[i] != '#')
                    stack2.Push(T[i]);
                else if (stack2.Any())
                    stack2.Pop();
            }
            if (stack1.Count != stack2.Count)
                return false;
            while (stack1.Any())
            {
                if (stack1.Pop() != stack2.Pop())
                    return false;
            }
            return true;

        }
    }
}

