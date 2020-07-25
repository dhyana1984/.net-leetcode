using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
 
    public class TreeToLinkTable
    {
        /*
         * 给定一个二叉树，原地将它展开为链表。

           例如，给定二叉树

               1
              / \
             2   5
            / \   \
           3   4   6
           将其展开为：

           1
            \
             2
              \
               3
                \
                 4
                  \
                   5
                    \
             6


         */
        TreeNode pre = null;

        public void Solution(TreeNode root)
        {
            if (root == null)
                return;
            Solution(root.right);
            Solution(root.left);
            root.right = pre;
            root.left = null;
            pre = root;

        }

    }
}
