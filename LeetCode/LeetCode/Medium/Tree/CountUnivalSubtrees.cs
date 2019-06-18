using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，统计该二叉树数值相同的子树个数。

        同值子树是指该子树的所有节点都拥有相同的数值。

        示例：

        输入: root = [5,1,5,5,5,null,5]

                      5
                     / \
                    1   5
                   / \   \
                  5   5   5

        输出: 
     */

   public class CountUnivalSubtrees
    {
        int result = 0;
        public int Solution(TreeNode root)
        {
            PostOrder(root);
            return result;
        }

        //走二叉树的后序遍历判断左右子树的值是否与当前子树根节点值相等，将结果返回给上一层
        private bool PostOrder(TreeNode node)
        {
            if (node == null)
                return true;
            bool l = PostOrder(node.left);
            bool r = PostOrder(node.right);

            bool cur = true;
            if (node.left != null && node.left.val != node.val)
                cur = false;
            if (node.right != null && node.right.val != node.val)
                cur = false;

            if (l && r && cur)
                result++;
            return l && r && cur;

        }

    }
}
