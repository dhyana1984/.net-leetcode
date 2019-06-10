using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
   public class PlusOne
    {
        /*
         * 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。

            最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。

            你可以假设除了整数 0 之外，这个整数不会以零开头。

            示例 1:

            输入: [1,2,3]
            输出: [1,2,4]
            解释: 输入数组表示数字 123。
            示例 2:

            输入: [4,3,2,1]
            输出: [4,3,2,2]
            解释: 输入数组表示数字 4321。
         */
        public int[] Solution(int[] digits)
        {
            int carry = 0;
            int[] resultArray = new int[digits.Length + 1];
            for (int i = digits.Length - 1; i >= 0; i--)
            {

                if (carry == 1 && i < digits.Length - 1 || i == digits.Length - 1)
                {
                    digits[i]++;
                    if (digits[i] == 10)
                    {
                        digits[i] = 0;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }

                resultArray[i + 1] = digits[i];

            }

            resultArray[0] = carry;
            return carry == 1 ? resultArray : resultArray.Skip<int>(1).ToArray();

        }
    }
}
