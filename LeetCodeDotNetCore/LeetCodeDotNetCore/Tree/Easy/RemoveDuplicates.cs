﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。

    不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。

    示例 1:

    给定数组 nums = [1,1,2], 

    函数应该返回新的长度 2, 并且原数组 nums 的前两个元素被修改为 1, 2。 

    你不需要考虑数组中超出新长度后面的元素。
    示例 2:

    给定 nums = [0,0,1,1,1,2,2,3,3,4],

    函数应该返回新的长度 5, 并且原数组 nums 的前五个元素被修改为 0, 1, 2, 3, 4。

    你不需要考虑数组中超出新长度后面的元素。
    说明:

    为什么返回数值是整数，但输出的答案是数组呢?

    请注意，输入数组是以“引用”方式传递的，这意味着在函数里修改输入数组对于调用者是可见的。

    你可以想象内部操作如下:

    // nums 是以“引用”方式传递的。也就是说，不对实参做任何拷贝
    int len = removeDuplicates(nums);

    // 在函数里修改输入数组对于调用者是可见的。
    // 根据你的函数返回的长度, 它会打印出数组中该长度范围内的所有元素。
    for (int i = 0; i < len; i++) {
        print(nums[i]);
    }
     */
    public class SolutionRemoveDuplicates
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1 || nums.Length == 0)
            {
                return nums.Length;
            }
            if (nums.Length == 2)
                return nums[0] == nums[1] ? 1 : 2;

            //int count = 0;
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        int a;
            //        if (nums[i] < nums[j])
            //        {
            //            a = nums[i + 1];
            //            nums[i + 1] = nums[j];
            //            nums[j] = a;
            //            count++;
            //            break;
            //        }
            //    }
            //    if (nums[i] == nums.Max())
            //        break;

            //}

            //可以放置两个指针 i 和 count，其中 count 是慢指针，而 i 是快指针。
            //只要 nums[count] = nums[i]，就增加 i以跳过重复项。
            //遇到 nums[i] != nums[count] 时，跳过重复项的运行已经结束，
            //因此我们必须把它（nums[i]）的值复制到 nums[count+ 1]。然后递增 count，
            //接着我们将再次重复相同的过程，直到 i 到达数组的末尾为止
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i]!=nums[count])
                {

                    count++;
                    nums[count] = nums[i];
                }

            }
            return count+1;

        }
    }
}
