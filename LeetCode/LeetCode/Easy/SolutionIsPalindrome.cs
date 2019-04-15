using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /* 9
     * 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。

        示例 1:

        输入: 121
        输出: true
        示例 2:

        输入: -121
        输出: false
        解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
        示例 3:

        输入: 10
        输出: false
        解释: 从右向左读, 为 01 。因此它不是一个回文数。
        进阶:

        你能不将整数转为字符串来解决这个问题吗？
     */
    public class SolutionIsPalindrome
    {
        public bool IsPalindrome(int x)
        {
            //string result = x.ToString();
            //if (new string(result.Reverse().ToArray()) == x.ToString())
            //    return true;
            //return false;


            int y = x;
            int num = 0;
            if (x < 0)
                return false;
            //反转一个整数
            while(x!=0)
            {
                num = x % 10 + num * 10;

                x /= 10;
            }
            return num == y;
        }
    }
}
