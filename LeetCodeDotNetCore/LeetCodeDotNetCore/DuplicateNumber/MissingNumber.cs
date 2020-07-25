using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DuplicateNumber
{
    /*
     * 给定一个包含 0, 1, 2, ..., n 中 n 个数的序列，找出 0 .. n 中没有出现在序列中的那个数。

        示例 1:

        输入: [3,0,1]
        输出: 2
        示例 2:

        输入: [9,6,4,2,3,5,7,0,1]
        输出: 8

     */
    public class MissingNumber
    {
        public int  Solution(int[] nums)
        {
            int a = 0;
            int b = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                a += nums[i];
                b += i;
            }
            b += nums.Length;
            return b - a;
        }
    }
}
