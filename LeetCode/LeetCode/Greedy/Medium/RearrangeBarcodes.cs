using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Medium
{
    /*
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
            /* 存在特殊情况结果类似 2, 1, 2, 1, 2
             * 因此优先使用出现次数最多的元素填充奇数位
             */
            /* 统计每个数据的出现次数 */
            int len = barcodes.Length;
            int[] count = new int[10001];
            for (int i = 0; i < len; i++)
            {
                count[barcodes[i]]++;
            }
            /* 得到出现次数最多的数字 */
            int maxCnt = 0;
            int maxNum = 0;
            maxCnt = count.Max();
            maxNum = Array.IndexOf(count, maxCnt);

            /* 先填充奇数位 */
            int[] result = new int[len];
            int pos = 0;    // result 填充位置
            int idx = 0;    // count 使用位置
                            /* 先使用出现次数最多的数字填充奇数位, 最多恰好填满 */
            while (pos < len)
            {
                if (count[maxNum] <= 0)
                {
                    break;  // 填充完毕
                }
                else
                {
                    count[maxNum]--;
                    result[pos] = maxNum;
                    pos += 2;
                }
            }
            /* 尝试继续填充奇数位 */
            while (pos < len)
            {
                if (count[idx] <= 0)
                {
                    idx++;
                    continue;
                }
                else
                {
                    count[idx]--;
                    result[pos] = idx;
                    pos += 2;
                }
            }
            /* 继续填充偶数位 */
            pos = 1;
            while (pos < len)
            {
                if (count[idx] <= 0)
                {
                    idx++;
                    continue;
                }
                else
                {
                    count[idx]--;
                    result[pos] = idx;
                    pos += 2;
                }
            }
            return result;



        }
    }
}
