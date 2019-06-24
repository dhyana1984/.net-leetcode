using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉搜索树的根节点 root 和一个值 key，删除二叉搜索树中的 key 对应的节点，并保证二叉搜索树的性质不变。返回二叉搜索树（有可能被更新）的根节点的引用。

        一般来说，删除节点可分为两个步骤：

        首先找到需要删除的节点；
        如果找到了，删除它。
        说明： 要求算法时间复杂度为 O(h)，h 为树的高度。

        示例:

        root = [5,3,6,2,4,null,7]
        key = 3

            5
           / \
          3   6
         / \   \
        2   4   7

        给定需要删除的节点值是 3，所以我们首先找到 3 这个节点，然后删除它。

        一个正确的答案是 [5,4,6,2,null,null,7], 如下图所示。

            5
           / \
          4   6
         /     \
        2       7

        另一个正确答案是 [5,2,6,null,4,null,7]。

            5
           / \
          2   6
           \   \
            4   7


     */
    public class DeleteNode
    {
        TreeNode theRoot = null;
        public TreeNode Solution(TreeNode root, int key)
        {
            if (root == null)
                return null;

            InOrder(root, key, root);
            if (key == root.val)
                return theRoot;
            return root;
        }

        private void InOrder(TreeNode node, int key, TreeNode root)
        {
            if (node == null)
                return;
            InOrder(node.left, key, node);
            if (node.val == key)
            {
                if (root.left == node)
                {
                    if (node.left != null && node.right != null)
                    {
                        root.left = node.right;
                        var left = node.right;
                        while(left.left!=null)
                        {
                            left = left.left;
                        }
                        left.left = node.left;
                    }
                    else if (node.right != null)
                        root.left = node.right;
                    else if (node.left != null)
                        root.left = node.left;
                    else
                        root.left = null;
                }
                else if (root.right == node)
                {
                    if (node.left != null && node.right != null)
                    {
                        root.right = node.left;
                      
                        var right = node.left;
      
                        while (right.right != null)
                        {
                            right = right.right;
                        }
                        right.right = node.right;
                    }
                    else if (node.right != null)
                        root.right = node.right;
                    else if (node.left != null)
                        root.right = node.left;
                    else
                        root.right = null;
                }
                else if (root == node)
                {
                    if (root.left != null && root.right != null)
                    {
                       
                        var right = root.right;
                        var left = root.left;
                        node = root.right;
                        root = root.right;
                        theRoot = root;
                        while (right.left != null)
                        {
                            right = right.left;
                        }
                        right.left = left;
                    }
                    else if (node.right != null)
                    {

                        root = root.right;
                        theRoot = node.right;
                    }
                    else if (node.left != null)
                    {

                        root = root.left;
                        theRoot = node.right;
                    }
                    else
                    {
                        node = null;
                    }

                }
                return;
            }

            InOrder(node.right, key, node);

        }
    }
}
