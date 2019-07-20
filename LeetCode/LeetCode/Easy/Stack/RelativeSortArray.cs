using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy.Stack
{
    /*
     * 给你两个数组，arr1 和 arr2，

        arr2 中的元素各不相同
        arr2 中的每个元素都出现在 arr1 中
        对 arr1 中的元素进行排序，使 arr1 中项的相对顺序和 arr2 中的相对顺序相同。未在 arr2 中出现过的元素需要按照升序放在 arr1 的末尾。

 

        示例：

        输入：arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
        输出：[2,2,2,1,4,3,3,9,6,7,19]


     */

    public class RelativeSortArray
    {
        public int[] Solution(int[] arr1, int[] arr2)
        {
            var res = new List<int>();
            var list = arr1.ToList();

   
            for (var i = 0; i < arr2.Length; i++)
            {

                while (list.IndexOf(arr2[i])>-1)
                {
                    res.Add(arr2[i]);
                    list.RemoveAt(list.IndexOf(arr2[i]));
                }
                

            }
            if (list.Count > 1)
            {
                list.Sort();
                res.AddRange(list);
            }
            
            return res.ToArray();
        }
    }
}
