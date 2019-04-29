using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定两个二进制字符串，返回他们的和（用二进制表示）。

        输入为非空字符串且只包含数字 1 和 0。

        示例 1:

        输入: a = "11", b = "1"
        输出: "100"
        示例 2:

        输入: a = "1010", b = "1011"
        输出: "10101"
     */
    public class AddBinary
    {
        public string Solution(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            char carry = '0';
            StringBuilder result = new StringBuilder();
            char temp;
            while (i >= -1 || j >= -1)
            {
                if (i >= 0 && j >= 0)
                {
                    if (a[i] == b[j])
                    {
                        temp = carry == '1' ? '1' : '0';
                        carry = a[i] == '1' ? '1' : '0';
                    }
                    else
                    {
                        temp = carry == '1' ? '0' : '1';
                        carry = carry == '1' ? '1' : '0';
                    }

                    i--;
                    j--;
                }
                else if (j >= 0)
                {
                    if (b[j] == carry)
                    {
                        temp = '0';
                        carry = carry == '1' ? '1' : '0';
                    }
                    else
                    {
                        temp = '1';
                        carry = '0';
                    }
                    j--;
                }
                else if (i >= 0)
                {
                    if (a[i] == carry)
                    {
                        temp = '0';
                        carry = carry == '1' ? '1' : '0';
                    }
                    else
                    {
                        temp = '1';
                        carry = '0';
                    }
                    i--;
                }
                else
                {

                    temp = carry;
                    if(carry=='1')
                    result.Insert(0, temp.ToString());
                    break;
                }                

           
                result.Insert(0, temp.ToString());

            }
            return result.ToString();
        }
    }
}

