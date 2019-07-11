using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{

    /*
     * 给定一个有 N 个节点的二叉树，每个节点都有一个不同于其他节点且处于 {1, ..., N} 中的值。

    通过交换节点的左子节点和右子节点，可以翻转该二叉树中的节点。

    考虑从根节点开始的先序遍历报告的 N 值序列。将这一 N 值序列称为树的行程。

    （回想一下，节点的先序遍历意味着我们报告当前节点的值，然后先序遍历左子节点，再先序遍历右子节点。）

    我们的目标是翻转最少的树中节点，以便树的行程与给定的行程 voyage 相匹配。 

    如果可以，则返回翻转的所有节点的值的列表。你可以按任何顺序返回答案。

    如果不能，则返回列表 [-1]。


     */

    public class FlipMatchVoyage
    {
        IList<int> res = new List<int>();
        int i = -1;
        public IList<int> Solution(TreeNode root, int[] voyage)
        {
            if (root == null)
                return res;

            InOrder(root, voyage);
            return res;
        }


        private void InOrder(TreeNode node, int[] voyage)
        {
            if (node == null)
                return;
            i++;
            if (node.val != voyage[i])
            {
                res.Clear();
                res.Add(-1);
                return;
            }
            if (node.left != null && node.right != null)
            {
                if (node.left.val != voyage[i + 1])
                {
                    TreeNode temp = node.left;
                    node.left = node.right;
                    node.right = temp;
                    res.Add(node.val);
                }
            }

            InOrder(node.left, voyage);
            InOrder(node.right, voyage);
        }
    }
}
