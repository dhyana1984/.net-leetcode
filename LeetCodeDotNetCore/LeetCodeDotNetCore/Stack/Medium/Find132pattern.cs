using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
    /*
     * 给定一个整数序列：a1, a2, ..., an，一个132模式的子序列 ai, aj, ak 被定义为：当 i < j < k 时，ai < ak < aj。设计一个算法，当给定有 n 个数字的序列时，验证这个序列中是否含有132模式的子序列。

    注意：n 的值小于15000。

    示例1:

    输入: [1, 2, 3, 4]

    输出: False

    解释: 序列中不存在132模式的子序列。
    示例 2:

    输入: [3, 1, 4, 2]

    输出: True

    解释: 序列中有 1 个132模式的子序列： [1, 4, 2].
    示例 3:

    输入: [-1, 3, 2, 0]

    输出: True

    解释: 序列中有 3 个132模式的的子序列: [-1, 3, 2], [-1, 3, 0] 和 [-1, 2, 0].


     */

    public class Find132pattern
    {
        public bool Solution(int[] nums)
        {
            var stack = new Stack<int>();
            var last = int.MinValue;
            for (int i = nums.Length - 1; i >= 0; i--)          //使用倒序遍历
            {
                //这时的last实际上是 ak,此时如果nums[i] < last，
                //last必然已经被赋过值，因为last初始值是int.MinValue
                //所以如果这里nums[i] < last成立，即可返回true
                if (nums[i] < last)                             
                    return true;
                while (stack.Any() && nums[i] > stack.Peek())   //如果当前遍历结果大于栈定，则表示aj, ak满足需求，把ak赋给last即可，然后aj进栈
                {
                    last = stack.Pop();
                }
                stack.Push(nums[i]);
            }
            return false;
        }
    }
}
