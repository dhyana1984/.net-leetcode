using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
    /*
     * 给定一个循环数组（最后一个元素的下一个元素是数组的第一个元素），输出每个元素的下一个更大元素。数字 x 的下一个更大的元素是按数组遍历顺序，这个数字之后的第一个比它更大的数，这意味着你应该循环地搜索它的下一个更大的数。如果不存在，则输出 -1。

        示例 1:

        输入: [1,2,1]
        输出: [2,-1,2]
        解释: 第一个 1 的下一个更大的数是 2；
        数字 2 找不到下一个更大的数； 
        第二个 1 的下一个最大的数需要循环搜索，结果也是 2。
        注意: 输入数组的长度不会超过 10000。


     */

    public class NextGreaterElements
    {
        public int[] Solution(int[] nums)
        {
            var stack = new Stack<int>();
            var res = new int[nums.Length];
            
            var list = new List<int>();
            list = nums.ToList();
            for (var i = 0; i < nums.Length; i++)                   //初始化结果数组，全部值为-1
            {
                res[i] = -1;
            }
            for (var i = 0; i < nums.Length * 2; i++)               //处理循环数组，用length*2 和%的方式来遍历
            {
                int num = nums[i % nums.Length];                    //取当前数组的值

                while (stack.Any() && num > nums[stack.Peek()])
                {
                    res[stack.Pop()] = num;

                }


                stack.Push(i % nums.Length);

            }
            return res;
        }
    }
}
