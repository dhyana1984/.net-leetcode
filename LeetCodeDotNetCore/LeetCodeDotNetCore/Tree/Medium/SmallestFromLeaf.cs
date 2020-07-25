using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一颗根结点为 root 的二叉树，书中的每个结点都有一个从 0 到 25 的值，分别代表字母 'a' 到 'z'：值 0 代表 'a'，值 1 代表 'b'，依此类推。

        找出按字典序最小的字符串，该字符串从这棵树的一个叶结点开始，到根结点结束。

        （小贴士：字符串中任何较短的前缀在字典序上都是较小的：例如，在字典序上 "ab" 比 "aba" 要小。叶结点是指没有子结点的结点。）

     */

    public class SmallestFromLeaf
    {
        string res = null;
        public string Solution(TreeNode root)
        {
            Dfs(root, new StringBuilder());
            return res;
        }

        void Dfs(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {


                return;

            }
            sb.Insert(0, (char)(root.val + 'a'));
            if (root.left == null && root.right == null)
            {
                string t = sb.ToString();
                if (res == null || t.CompareTo(res) < 0)
                    res = t;
            }
            Dfs(root.left, sb);
            if (root.left != null)
                sb.Remove(0, 1);
            Dfs(root.right, sb);
            if (root.right != null)
                sb.Remove(0, 1);

        }
    }
}
