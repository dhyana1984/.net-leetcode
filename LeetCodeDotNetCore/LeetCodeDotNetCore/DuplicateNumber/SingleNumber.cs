using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     * 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

        说明：

        你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

        示例 1:

        输入: [2,2,1]
        输出: 1
        示例 2:

        输入: [4,1,2,1,2]
        输出: 4


        按位异或的3个特点
        参与运算的两个值，如果两个相应bit位相同，则结果为0，否则为1。
        (1) 0^0=0,0^1=1  0异或任何数＝任何数
        (2) 1^0=1,1^1=0  1异或任何数－任何数取反
        (3) 任何数异或自己＝把自己置0

        按位异或的几个常见用途:
        (1) 使某些特定的位翻转
           例如对数10100001的第2位和第3位翻转，则可以将该数与00000110进行按位异或运算。
　　　　　  10100001^00000110 = 10100111

        (2) 实现两个值的交换，而不必使用临时变量。
            例如交换两个整数a=10100001，b=00000110的值，可通过下列语句实现：
　　　　        a = a^b； 　　//a=10100111
　　　　        b = b^a； 　　//b=10100001
　　　　        a = a^b； 　　//a=00000110

        (3) 在汇编语言中经常用于将变量置零：
            xor   a，a

        (4) 快速判断两个值是否相等
            举例1: 判断两个整数a，b是否相等，则可通过下列语句实现：
                return ((a ^ b) == 0)

     */
    public class SingleNumber
    {
        public int Solution(int[] nums)
        {
            //Array.Sort(nums);
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (i == 0 && nums[i] != nums[i + 1])
            //    {
            //        return nums[i];
            //    }
            //    if (i == nums.Length - 1 && nums[i] != nums[i - 1])
            //    {
            //        return nums[i];
            //    }
            //    if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
            //    {
            //        return nums[i];
            //    }
            //}
            //return 0;
            int res = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                res = res ^ nums[i];
            }
            return res;
        }
    }
}
