using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，找到其中最大的二叉搜索树（BST）子树，其中最大指的是子树节点数最多的。

        注意:
        子树必须包含其所有后代。

        示例:

        输入: [10,5,15,1,8,null,7]

           10 
           / \ 
          5  15 
         / \   \ 
        1   8   7

        输出: 3
        解释: 高亮部分为最大的 BST 子树。
             返回值 3 在这个样例中为子树大小。


     */

    public class LargestBSTSubtree
    {
        int result = 0;
        int count = 0;
        List<int> list = new List<int>();
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            FindMaxBST(root);
            return result;
        }

        private bool FindMaxBST(TreeNode root)
        {

            bool lbst = true;
            bool rbst = true;
            bool bst = true;
            int l = list.Count;
            int r = list.Count;
            if (root.left != null)
            {
                lbst = FindMaxBST(root.left);
                if (!lbst || root.val <= list.Last())
                {
                    bst = false;
                }

            }
            list.Add(root.val);
            r = list.Count;
            if (root.right != null)
            {
                rbst = FindMaxBST(root.right);
                if (!rbst || root.val >= list[r])
                {
                    bst = false;
                }
            }
            r = list.Count;
            if (bst)
            {
                result = Math.Max(result, r - l);
            }

            return bst;

        }
    }
}
