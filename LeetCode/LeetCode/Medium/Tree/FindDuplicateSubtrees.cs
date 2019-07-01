using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一棵二叉树，返回所有重复的子树。对于同一类的重复子树，你只需要返回其中任意一棵的根结点即可。

        两棵树重复是指它们具有相同的结构以及相同的结点值。

        示例 1：

                1
               / \
              2   3
             /   / \
            4   2   4
               /
              4
        下面是两个重复的子树：

              2
             /
            4
        和

            4
        因此，你需要以列表的形式返回上述重复子树的根结点。


     */

    public class FindDuplicateSubtrees
    {
        Dictionary<string, IList<TreeNode>> dict = new Dictionary<string, IList<TreeNode>>();
        IList<TreeNode> list = new List<TreeNode>();
        public IList<TreeNode> Solution(TreeNode root)
        {
            PostOrder(root);

            return list;


        }

        private string PostOrder(TreeNode node)
        {
            if (node == null)
            {
                return "N";
            }
            string left = PostOrder(node.left);
            string right = PostOrder(node.right);
            string s = node.val.ToString() + left + right;
            if (!dict.ContainsKey(s))
                dict[s] = new List<TreeNode> { node };
            else
            {
                dict[s].Add(node);
                if (dict[s].Count > 1 && !list.Contains(dict[s].First()))
                    list.Add(dict[s].First());
            }

            return s;
        }
    }
}
