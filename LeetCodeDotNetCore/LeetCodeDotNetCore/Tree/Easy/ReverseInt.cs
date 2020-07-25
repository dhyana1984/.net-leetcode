using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class SolutionReverseInt
    {
        /*
         * 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

            示例 1:

            输入: 123
            输出: 321
             示例 2:

            输入: -123
            输出: -321
            示例 3:

            输入: 120
            输出: 21
            注意:

            假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。
         */
        public int Reverse(int x)
        {

            //int result = 0;
            //string strResult = "";
            //double max = Math.Pow(2, 31) - 1;
            //double min = Math.Pow(-2, 31);
            //if (x < 10 && x > -10)
            //{
            //    return x;
            //}
            //strResult = new string(x.ToString().Reverse().ToArray());
            //if (x > 0)
            //{  

            //    result = double.Parse(strResult) > max ? 0 : int.Parse(strResult);                 
            //}
            //else
            //{
            //    strResult = strResult.TrimEnd('-');
            //    result = double.Parse("-"+strResult) < min ? 0 : int.Parse("-" +strResult);
            //}


            long num = 0;
            //反转一个整数
            while (x != 0)
            {
                num = x % 10 + num * 10;
                if(num > int.MaxValue || num < int.MinValue)
                {
                    return 0;
                }
                x /= 10;
            }

            return (int)num;
            
        }
    }
}
