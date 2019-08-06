using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Heap.Easy
{
    /*
     * 
     * 设计一个找到数据流中第K大元素的类（class）。注意是排序后的第K大元素，不是第K个不同的元素。

        你的 KthLargest 类需要一个同时接收整数 k 和整数数组nums 的构造器，它包含数据流中的初始元素。每次调用 KthLargest.add，返回当前数据流中第K大的元素。

        示例:

        int k = 3;
        int[] arr = [4,5,8,2];
        KthLargest kthLargest = new KthLargest(3, arr);
        kthLargest.add(3);   // returns 4
        kthLargest.add(5);   // returns 5
        kthLargest.add(10);  // returns 5
        kthLargest.add(9);   // returns 8
        kthLargest.add(4);   // returns 8
        说明: 
        你可以假设 nums 的长度≥ k-1 且k ≥ 1。

     */
    public class KthLargest
    {


        List<int> list;
        int index;
        public KthLargest(int k, int[] nums)
        {
            index = k - 1;

            nums = nums.OrderByDescending(t => t).ToArray();    //倒序排列nums     
            list = new List<int>();
            for (var i = 0; i < k; i++)
            {
                if (i >= nums.Length)
                    list.Add(int.MinValue);    //填充一个长度为k的list, 如果nums没有k长度，用int.MinValue填充
                else
                    list.Add(nums[i]);
            }

        }

        public int Add(int val)
        {
            if (list.Any())
            {
                if (val > list[0])                          //如果add的值大于list最大值，在list头插入val并且去掉list的尾部最小值
                {
                    list.RemoveAt(list.Count - 1);
                    list.Insert(0, val);
                    return list[list.Count - 1];           //返回尾部最小值，此时该值就是第k个最大元素
                }
                if (val <= list.Last())
                {
                    return list.Last();                     //如果val小于等于最小值，返回list最小值即可
                }

                for (var i = 0; i < list.Count - 1; i++)            //如果val在list中间
                {
                    if (val <= list[i] && val >= list[i + 1])       //找到val的位置插入，并去掉list尾部值，再返回尾部值
                    {
                        list.Insert(i + 1, val);
                        list.RemoveAt(list.Count - 1);
                        return list[list.Count - 1];
                    }

                }
            }
            else
                list.Add(val);              //如果只有1个元素，返回该元素
            return list[0];

        }
    }
}
