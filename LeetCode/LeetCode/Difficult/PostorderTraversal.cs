using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Difficult
{
    /*
     * 给定一个二叉树，返回它的 后序 遍历。迭代方式
     */
    public class PostorderTraversal
    {
        public IList<int> Solution(TreeNode root)
        {
            IList<int> resultList = new List<int>();
            if (root != null)
            {
                Stack<TreeNode> stack = new Stack<TreeNode>();
                stack.Push(root);
                while (stack.Any())
                {
                    TreeNode node = stack.Pop();
                    resultList.Insert(0, node.val);
                    if (node.left != null)
                        stack.Push(node.left);
                    if (node.right != null)
                        stack.Push(node.right);
                }
            }

            return resultList;
        }
    }
}
