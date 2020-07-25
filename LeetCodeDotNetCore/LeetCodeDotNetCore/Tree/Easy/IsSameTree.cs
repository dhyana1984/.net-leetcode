using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class IsSameTree
    {
        



        public bool Solution(TreeNode p, TreeNode q)
        {
            if (p == q && p == null)
                return true;
            if (p == null)
                return false;
            if (q == null)
                return false;
            Stack<TreeNode> stackP = new Stack<TreeNode>();
            stackP.Push(p);
            Stack<TreeNode> stackQ = new Stack<TreeNode>();
            stackQ.Push(q);
            TreeNode pNode = null;
            TreeNode qNode = null;
            while (stackP.Any() || stackQ.Any())
            {
                if (!(stackP.Any() && stackQ.Any()))
                    return false;
                 pNode = stackP.Pop();
                 qNode = stackQ.Pop();

                if (pNode == qNode && pNode == null)
                    continue;
                if (pNode == null)
                    return false;
                if (qNode == null)
                    return false;

                if (pNode.val != qNode.val)
                    return false;
                else
                {
                    stackP.Push(pNode.right);
                    stackQ.Push(qNode.right);
                    stackP.Push(pNode.left);
                    stackQ.Push(qNode.left);
                }

            }
            return true;

        }
    }
}
