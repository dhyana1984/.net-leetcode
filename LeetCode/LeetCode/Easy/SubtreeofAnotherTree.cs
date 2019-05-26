using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定两个非空二叉树 s 和 t，检验 s 中是否包含和 t 具有相同结构和节点值的子树。s 的一个子树包括 s 的一个节点和这个节点的所有子孙。s 也可以看做它自身的一棵子树。

        示例 1:
        给定的树 s:

             3
            / \
           4   5
          / \
         1   2
        给定的树 t：

           4 
          / \
         1   2
        返回 true，因为 t 与 s 的一个子树拥有相同的结构和节点值。

        示例 2:
        给定的树 s：

             3
            / \
           4   5
          / \
         1   2
            /
           0
        给定的树 t：

           4
          / \
         1   2
        返回 false。
     */
    public class SubtreeofAnotherTree
    {
        public bool Solution(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
                return true;
            if (s != null && t != null)//s,t都不能为空的情况才能递归
            {
                if (s.val == t.val && IsSame(s, t))//当此时s和t值一致才判断是否是子树
                    return true;
                if (Solution(s.left, t) || Solution(s.right, t))//递归s的左右子树
                    return true;
            }
            return false;


        }
        //判断是否是一样结构的树
        public bool IsSame(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
                return true;
            if (s != null && t != null && s.val == t.val)
                return IsSame(s.left, t.left) && IsSame(s.right, t.right);
            return false;
        }


    }
}
