using LeetCode.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{

    public class SolNextLargerNodesution
    {
        public int[] Solutioj(ListNode head)
        {
            // 1. 创建一个容器 list 来存储数据
            var list = new List<int>();
            int size = 0;
            while (head != null)
            {
                list.Add(head.val);
                size++;
                head = head.next;
            }
            // 2. 创建一个栈 stack ，这个栈里面存储的是对应位置的 list 元素及其之后元素中最大的值。        
            var stack = new Stack<int>();
            int[] ans = new int[size];
            // 3. 在 list 中从右往左遍历，stack 中凡是比 list[i] 小的都 pop 出去，
            // 这样 stack 剩下的元素都是比 list[i] 更大的元素。
            for (int i = list.Count - 1; i >= 0; i--)
            {
                while (stack.Any() && stack.Peek() <= list[i])
                {
                    stack.Pop();
                }
                ans[i] = !stack.Any() ? 0 : stack.Peek();
                stack.Push(list[i]);
            }
            return ans.ToArray();


        }
    }
}
