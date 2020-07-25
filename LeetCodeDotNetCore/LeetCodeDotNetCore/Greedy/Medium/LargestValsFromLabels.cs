using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Medium
{
    /*
     * 我们有一个项的集合，其中第 i 项的值为 values[i]，标签为 labels[i]。

        我们从这些项中选出一个子集 S，这样一来：

        |S| <= num_wanted
        对于任意的标签 L，子集 S 中标签为 L 的项的数目总满足 <= use_limit。
        返回子集 S 的最大可能的 和。

 

        示例 1：

        输入：values = [5,4,3,2,1], labels = [1,1,2,2,3], num_wanted = 3, use_limit = 1
        输出：9
        解释：选出的子集是第一项，第三项和第五项。
        示例 2：

        输入：values = [5,4,3,2,1], labels = [1,3,3,3,2], num_wanted = 3, use_limit = 2
        输出：12
        解释：选出的子集是第一项，第二项和第三项。
        示例 3：

        输入：values = [9,8,8,7,6], labels = [0,0,0,1,1], num_wanted = 3, use_limit = 1
        输出：16
        解释：选出的子集是第一项和第四项。
        示例 4：

        输入：values = [9,8,8,7,6], labels = [0,0,0,1,1], num_wanted = 3, use_limit = 2
        输出：24
        解释：选出的子集是第一项，第二项和第四项。

     */

    public class LargestValsFromLabels
    {
        public int Solution(int[] values, int[] labels, int num_wanted, int use_limit)
        {
            if (num_wanted == 0 || use_limit == 0)
            {
                return 0;
            }
            /* 解法一
            var listValues = values.ToList();
            var listLabel = labels.ToList();
            var dict = new Dictionary<int, int>();
            var res = 0;
            while (listValues.Any() && num_wanted > 0)
            {

                var max = listValues.Max();
                var index = listValues.IndexOf(max);
                var label = listLabel[index];
                if (!dict.ContainsKey(label) || dict[label] < use_limit)
                {
                    res += max;
                    if (!dict.ContainsKey(label))
                        dict[label] = 1;
                    else
                        dict[label] += 1;
                    listValues.RemoveAt(index);
                    listLabel.RemoveAt(index);
                    num_wanted--;
                }
                else
                {
                    listValues.RemoveAt(index);
                    listLabel.RemoveAt(index);
                }

            }
            return res;
            */
            //解法二
            var len = values.Length;
            int[][] pairs = new int[len][];
            var ans = 0;
            var cnt = 0;
            int[] numLabel = new int[20001];  // max{label} = 20000
            for (var i = 0; i < len; i++)
            {
                pairs[i] = new int[2];
                pairs[i][0] = values[i];
                pairs[i][1] = labels[i];
            }

            pairs = pairs.OrderByDescending(t => t[0]).ToArray();
            for (int i = 0; i < len; i++)
            {
                var lab = pairs[i][1];
                if (numLabel[lab] >= use_limit)
                    continue;
                ans += pairs[i][0];
                numLabel[lab]++;
                cnt++;
                if(cnt>=num_wanted)
                {
                    return ans;
                }

            }
            return ans;


        }
    }
}
