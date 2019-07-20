using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    public class IsSymmetric
    {

          //给定一个二叉树，检查它是否是镜像对称的。

          //  例如，二叉树 [1,2,2,3,4,4,3] 是对称的。

          //      1
          //     / \
          //    2   2
          //   / \ / \
          //  3  4 4  3
          //  但是下面这个 [1,2,2,null,3,null,3] 则不是镜像对称的:

          //      1
          //     / \
          //    2   2
          //     \   \
          //     3    3
          //  说明:

          //  如果你可以运用递归和迭代两种方法解决这个问题，会很加分。
       
        public bool Solution(TreeNode root)
        {
            //return IsMirrorTree(root, root);//递归解法


            //遍历解法
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root);
            TreeNode t1 = null;
            TreeNode t2 = null;
            while (queue.Any())
            {
                t1 = queue.Dequeue();
                t2 = queue.Dequeue();
                if (t1 == null && t2 == null)
                    continue;
                if (t1 == null || t2 == null)
                    return false;
                if (t1.val != t2.val)
                    return false;
                queue.Enqueue(t1.left);
                queue.Enqueue(t2.right);
                queue.Enqueue(t1.right);
                queue.Enqueue(t2.left);
            }

            return true;



        }

        private bool IsMirrorTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return false;
            if (t1 == t2)//如果传进去的是根节点，则直接比较左右子树，避免重复比较
                return IsMirrorTree(t1.left, t2.right);
            return (t1.val == t2.val) && IsMirrorTree(t1.left, t2.right) && IsMirrorTree(t1.right, t2.left);
        }
    }
}
