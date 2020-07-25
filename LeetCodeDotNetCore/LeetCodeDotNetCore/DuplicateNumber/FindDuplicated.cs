using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DuplicateNumber
{
    /*
     * 给定一个包含 n + 1 个整数的数组 nums，其数字都在 1 到 n 之间（包括 1 和 n），可知至少存在一个重复的整数。假设只有一个重复的整数，找出这个重复的数。

        示例 1:

        输入: [1,3,4,2,2]
        输出: 2
        示例 2:

        输入: [3,1,3,4,2]
        输出: 3

     */
    public class FindDuplicate
    {
        public int  Solution(int[] nums)
        {
            // Array.Sort(nums);
            // for(var i=1;i<nums.Length;i++){
            //     if(nums[i]==nums[i-1])
            //         return nums[i];
            // }
            // return 0;

            var mySet = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!mySet.Contains(item))
                {
                    mySet.Add(item);
                }
                else
                {
                    return item;
                }
            }
            return 0;
        }
    }
}
