using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    /*
     * 如果二叉树每个节点都具有相同的值，那么该二叉树就是单值二叉树。

        只有给定的树是单值二叉树时，才返回 true；否则返回 false。
     */
    public class UnivaluedBinaryTree
    {
        public bool Solution(TreeNode root)
        {
            if (root == null)
                return true;

            //递归解法
            //else
            //{
            //    var val = root.val;
            //    bool result = true;
            //    if (root.left != null)
            //        result = root.left.val == val;
            //    if (root.right != null)
            //        result = result && (root.right.val == val);

            //    return result && Solution(root.left) && Solution(root.right);
            //}



            //遍历解法
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var node = new TreeNode(0);
            while (queue.Any())
            {
                node = queue.Dequeue();
                if (node.left != null)
                {
                    if (node.left.val != node.val)
                        return false;
                    else
                        queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    if (node.right.val != node.val)
                        return false;
                    else
                        queue.Enqueue(node.left);
                }

            }
            return true;
        }
    }
}
