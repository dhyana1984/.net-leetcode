using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     给你一个二叉搜索树和其中的某一个结点，请你找出该结点在树中顺序后继的节点。

结点 p 的后继是值比 p.val 大的结点中键值最小的结点。
         */

    public class InorderSuccessor1
    {
        TreeNode result = null;
        bool flag = false;
        public TreeNode Solution(TreeNode root, TreeNode p)
        {
            InOrder(root, p);
            return result;
        }

        private void InOrder(TreeNode node, TreeNode target)
        {
            if (node == null)
                return;
            InOrder(node.left, target);
            if (flag && result == null)
                result = node;
            if (node == target)
                flag = true;

            InOrder(node.right, target);
        }
    }
}
