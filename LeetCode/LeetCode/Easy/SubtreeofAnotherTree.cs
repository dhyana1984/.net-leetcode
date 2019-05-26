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
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            Queue<TreeNode> queueS = new Queue<TreeNode>();
            Queue<TreeNode> queueT = new Queue<TreeNode>();
            queueS.Enqueue(s);
            queueT.Enqueue(t);
            TreeNode nodeS;
            TreeNode nodeT;
            while (queueS.Any())
            {
                nodeS = queueS.Dequeue();

                var flag = IsTheSame(nodeS, queueT);
                if (!flag)
                {
                    queueT = new Queue<TreeNode>();
                    queueT.Enqueue(t);
                }
                if (!queueT.Any() && nodeS.left == null && nodeS.right == null)
                {
                    return true;

                }
                if (nodeS.left != null)
                    queueS.Enqueue(nodeS.left);
                if (nodeS.right != null)
                    queueS.Enqueue(nodeS.right);
            }

            return false;
        }

        private bool IsTheSame(TreeNode nodeS, Queue<TreeNode> queueT)
        {
            var nodeT = queueT.Dequeue();
            if (nodeS.val == nodeT.val)
            {

                if (nodeT.left != null)
                    queueT.Enqueue(nodeT.left);
                if (nodeT.right != null)
                    queueT.Enqueue(nodeT.right);

                return true;
            }
            return false;
        }

    }
}
