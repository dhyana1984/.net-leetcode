using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SingleNumber
    {
        public int Solution(int[] nums)
        {
            Array.Sort(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0 && nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
                if (i == nums.Length - 1 && nums[i] != nums[i - 1])
                {
                    return nums[i];
                }
                if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return 0;
        }
    }
}
