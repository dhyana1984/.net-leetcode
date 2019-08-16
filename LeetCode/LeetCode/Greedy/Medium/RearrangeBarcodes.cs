using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Medium
{
    /*
     * 
     * 在一个仓库里，有一排条形码，其中第 i 个条形码为 barcodes[i]。

        请你重新排列这些条形码，使其中两个相邻的条形码 不能 相等。 你可以返回任何满足该要求的答案，此题保证存在答案。

 

        示例 1：

        输入：[1,1,1,2,2,2]
        输出：[2,1,2,1,2,1]
        示例 2：

        输入：[1,1,1,1,2,2,3,3]
        输出：[1,3,1,3,2,1,2,1]
 

        提示：

        1 <= barcodes.length <= 10000
        1 <= barcodes[i] <= 10000

     */

    public class RearrangeBarcodes
    {
        public int[] Solution(int[] barcodes)
        {
            var stack1 = new Stack<int>(barcodes);
            var stack2 = new Stack<int>();
            var res = new List<int>();
            while (stack1.Any())
            {
                var p1 = stack1.Pop();
                if (res.Count == 0)
                    res.Add(p1);
                if (stack1.Any() && stack1.Peek() != res.Last())
                {
                    res.Add(p1);
                    continue;
                }
                else if (stack1.Any() && stack1.Peek() == res.Last())
                {
                    if (stack2.Any() && stack2.Peek() != res.Last())
                    {
                        res.Add(stack2.Pop());

                    }

                    stack2.Push(p1);
                }

            }
            return res.ToArray();

        }
    }
}
