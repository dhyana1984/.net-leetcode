using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    /*
     * 给定一个二叉树，计算整个树的坡度。

        一个树的节点的坡度定义即为，该节点左子树的结点之和和右子树结点之和的差的绝对值。空结点的的坡度是0。

        整个树的坡度就是其所有节点的坡度之和。

        示例:

        输入: 
                 1
               /   \
              2     3
        输出: 1
        解释: 
        结点的坡度 2 : 0
        结点的坡度 3 : 0
        结点的坡度 1 : |2-3| = 1
        树的坡度 : 0 + 0 + 1 = 1
        注意:

        任何子树的结点的和不会超过32位整数的范围。
        坡度的值不会超过32位整数的范围。
     */
    public class BinTreeFindTilt
    {
        //双递归 
        //public int Solution(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;

        //    int left = 0;
        //    int right = 0;
        //    if(root.left!=null)
        //        left = SumAllChildVal(root.left)+root.left.val;
        //    if (root.right != null)
        //        right = SumAllChildVal(root.right) + root.right.val;

        //    return Solution(root.left) + Solution(root.right) + Math.Abs(left-right);
        //}

        //private int SumAllChildVal(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;
        //    int val = root.val;
        //    int left = root.left == null ? 0 : root.left.val;
        //    int right = root.right == null ? 0 : root.right.val;
        //    int result =  right + left;
        //    return SumAllChildVal(root.left) + SumAllChildVal(root.right) + result;
        //}

        //单递归
        int result = 0;
        public int Solution(TreeNode root)
        {
            SumAllChildVal(root);
            return result;

        }

        private int SumAllChildVal(TreeNode root)
        {
            if (root == null)
                return 0;
            int val = root.val;
            int left = SumAllChildVal(root.left);
            int right = SumAllChildVal(root.right);
            result += Math.Abs(left - right);
            return left + right + val;
        }
    }
}
