using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{

    /*
     * 给定一个二叉搜索树（Binary Search Tree），把它转换成为累加树（Greater Tree)，使得每个节点的值是原来的节点值加上所有大于它的节点值之和。

        例如：

        输入: 二叉搜索树:
                      5
                    /   \
                   2     13

        输出: 转换为累加树:
                     18
                    /   \
          20     13
     */
    public class ConvertBST
    {


        List<TreeNode> list = new List<TreeNode>();

        int sum = 0;
        public TreeNode Solution(TreeNode root)
        {

            if (root == null || root.left == null && root.right == null) return root;
            InOrder(root);



            return root;

        }

        private void InOrder(TreeNode node)
        {
            if (node == null)
                return;

            //从右中左的顺序遍历，累加节点的值
            InOrder(node.right);

            sum += node.val;
            node.val = sum;

            InOrder(node.left);
        }
    }
}
