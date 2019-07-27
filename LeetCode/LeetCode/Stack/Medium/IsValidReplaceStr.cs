using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
    /*
     * 给定有效字符串 "abc"。

        对于任何有效的字符串 V，我们可以将 V 分成两个部分 X 和 Y，使得 X + Y（X 与 Y 连接）等于 V。（X 或 Y 可以为空。）那么，X + "abc" + Y 也同样是有效的。

        例如，如果 S = "abc"，则有效字符串的示例是："abc"，"aabcbc"，"abcabc"，"abcabcababcc"。无效字符串的示例是："abccba"，"ab"，"cababc"，"bac"。

        如果给定字符串 S 有效，则返回 true；否则，返回 false。

 

        示例 1：

        输入："aabcbc"
        输出：true
        解释：
        从有效字符串 "abc" 开始。
        然后我们可以在 "a" 和 "bc" 之间插入另一个 "abc"，产生 "a" + "abc" + "bc"，即 "aabcbc"。


     */

    public class IsValidReplaceStr
    {
        public bool Solution(string S)
        {
            while (S.Contains("abc"))
                S = S.Replace("abc", "");
            return S == "";
        }
    }
}
