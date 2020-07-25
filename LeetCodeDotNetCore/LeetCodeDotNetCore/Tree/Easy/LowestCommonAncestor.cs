using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    /*给定一个二叉搜索树, 找到该树中两个指定节点的最近公共祖先。

     二叉查找树（Binary Search Tree），（
     又：二叉搜索树，二叉排序树）它或者是一棵空树，或者是具有下列性质的二叉树： 
     若它的左子树不空，则左子树上所有结点的值均小于它的根结点的值； 
     若它的右子树不空，则右子树上所有结点的值均大于它的根结点的值； 它的左、右子树也分别为二叉排序树。

        例如，给定如下二叉搜索树:  root = [6,2,8,0,4,7,9,null,null,3,5]
     */
    public class LowestCommonAncestor
    {
        public TreeNode Solution(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root != null)
            {
                var pValue = p.val;
                var qValue = q.val;
                TreeNode result = new TreeNode(0);

                //第一种情况，都在root右边
                if (pValue > root.val && qValue > root.val)
                {
                    if (root == p)
                        return p;
                    if (root == q)
                        return q;
                    if (root.left == q && root.right == p || root.left == p && root.right == q)
                        return root;

                    result = Solution(root.right, p, q);

                }
                //第二种情况，都在root左边
                else if (pValue < root.val && qValue < root.val)
                {
                    if (root == p)
                        return p;
                    if (root == q)
                        return q;
                    if (root.left == q && root.right == p || root.left == p && root.right == q)
                        return root;

                    result = Solution(root.left, p, q);
                }
                //第三种情况，在root的两边
                else
                {
                    return root;
                }
                return result;
            }

            return null;
        }
    }
}
