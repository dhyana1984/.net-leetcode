using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
    /*
     * 给定一个以字符串表示的非负整数 num，移除这个数中的 k 位数字，使得剩下的数字最小。

        注意:

        num 的长度小于 10002 且 ≥ k。
        num 不会包含任何前导零。
        示例 1 :

        输入: num = "1432219", k = 3
        输出: "1219"
        解释: 移除掉三个数字 4, 3, 和 2 形成一个新的最小的数字 1219。
        示例 2 :

        输入: num = "10200", k = 1
        输出: "200"
        解释: 移掉首位的 1 剩下的数字为 200. 注意输出不能有任何前导零。
        示例 3 :

        输入: num = "10", k = 2
        输出: "0"
        解释: 从原数字移除所有的数字，剩余为空就是0。

     */

    public class RemoveKdigits
    {
        public string Solution(string num, int k)
        {
            var n = num.Length;
            if (k == 0) return num;
            if (n <= k) return "0";
            var list = new List<char>();
            string res = "";
            for (var t = 0; t < n; t++)
            {
                while (list.Any() && list.Last() > num[t] && k != 0)
                {
                    list.RemoveAt(list.Count - 1);
                    k--;
                }
                list.Add(num[t]);
            }

            while (k != 0)
            {
                list.RemoveAt(list.Count - 1);
                k--;
            }
            int i = 0;
            for (; i < list.Count; i++)
            {
                if (list[i] != '0')
                    break;

            }
            for (var j = i; j < list.Count; j++)
            {
                res += list[j];
            }

            return res == "" ? "0" : res;


        }
    }
}
