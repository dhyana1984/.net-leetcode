using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Medium
{
    /*
     * 给定一个非负整数数组，你最初位于数组的第一个位置。

        数组中的每个元素代表你在该位置可以跳跃的最大长度。

        判断你是否能够到达最后一个位置。

        示例 1:

        输入: [2,3,1,1,4]
        输出: true
        解释: 从位置 0 到 1 跳 1 步, 然后跳 3 步到达最后一个位置。
        示例 2:

        输入: [3,2,1,0,4]
        输出: false
        解释: 无论怎样，你总会到达索引为 3 的位置。但该位置的最大跳跃长度是 0 ， 所以你永远不可能到达最后一个位置。


     */

    public class CanJump
    {
        public bool Solution(int[] nums)
        {
            if (nums.Length == 1)
                return true;

            var step = 0;
            var index = 0;
            while (index < nums.Length)
            {

                step = nums[index];
                for (var j = index + 1; j <= index + step; j++)
                {
                    if (j + nums[j] >= nums.Length - 1)
                        return true;
                    if (j < nums.Length && nums[j] >= step)
                    {
                        step = nums[j];
                        index = j;
                    }
                }
                index += step;

                if (step == 0 && index < nums.Length - 1)
                    break;
                if (index >= nums.Length - 1)
                    return true;
            }


            return false;
        }
    }
}
