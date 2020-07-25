using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
   public class SolutionSearchInsert
    {
        /*
         * 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。
         * 如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
         *   你可以假设数组中无重复元素。
         */
      
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;
            if (target <= nums[0] || target > nums[nums.Length - 1])
                return target <= nums[0] ? 0 : nums.Length;
            int result = -1;
            for (int i = 1; i < nums.Length; i++)
                if (target <= nums[i] && target > nums[i - 1])
                    result = Array.IndexOf(nums, nums[i]);

            return result;
        }
        
    }
}
