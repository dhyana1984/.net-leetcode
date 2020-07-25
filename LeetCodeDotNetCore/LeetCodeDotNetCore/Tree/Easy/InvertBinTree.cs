using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    /*
     * 翻转一棵二叉树。

        示例：

        输入：

             4
           /   \
          2     7
         / \   / \
        1   3 6   9
        输出：

             4
           /   \
          7     2
         / \   / \
        9   6 3   1
     */
    public  class InvertBinTree
    {
        public TreeNode Solution(TreeNode root)
        {
            if (root != null)
            {
                TreeNode tempNode;
                tempNode = root == null ? null : Solution(root.left);
                root.left = root == null ? null : Solution(root.right);
                root.right = tempNode;
            }

            return root;
        }
    }
}
