using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个整数数组，你需要验证它是否是一个二叉搜索树正确的先序遍历序列。

        你可以假定该序列中的数都是不相同的。

        参考以下这颗二叉搜索树：

             5
            / \
           2   6
          / \
         1   3
        示例 1：

        输入: [5,2,6,1,3]
        输出: false
        示例 2：

        输入: [5,2,1,3,6]
        输出: true

     */

    public class VerifyPreorderBST
    {
        public bool Solution(int[] preorder)
        {
            /*
             * 先序遍历，如果递减，一定是左子树；
                如果出现非递减的值，意味着到了某个节点的右子树；
                利用栈来寻找该节点，最后一个比当前元素小的从栈弹出的元素即为该节点的父亲节点，而且当前元素父节点即为新的下限值；
                后续的元素一定是比当前的下限值要大的，否则return false；

             */
            if (!preorder.Any())
                return true;
            int min = int.MinValue;
            var stack = new Stack<int>();

            for (int i = 0; i < preorder.Count(); i++)
            {
                if (preorder[i] < min)
                    return false;

                while (stack.Any() && preorder[i]> stack.Peek())
                {
                    min = stack.Pop();
                }
                stack.Push(preorder[i]);
            }
            return true;

        }
    }
}
