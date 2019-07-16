using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给你一个有根节点的二叉树，找到它最深的叶节点的最近公共祖先。

        回想一下：

        叶节点 是二叉树中没有子节点的节点
        树的根节点的 深度 为 0，如果某一节点的深度为 d，那它的子节点的深度就是 d+1
        如果我们假定 A 是一组节点 S 的 最近公共祖先，<font color="#c7254e" face="Menlo, Monaco, Consolas, Courier New, monospace">S</font> 中的每个节点都在以 A 为根节点的子树中，且 A 的深度达到此条件下可能的最大值。
 

        示例 1：

        输入：root = [1,2,3]
        输出：[1,2,3]
        示例 2：

        输入：root = [1,2,3,4]
        输出：[4]
        示例 3：

        输入：root = [1,2,3,4,5]
        输出：[2,4,5]
 

        提示：

        给你的树中将有 1 到 1000 个节点。
        树中每个节点的值都在 1 到 1000 之间。


     */


   public class LcaDeepestLeaves
    {

        public TreeNode Solution(TreeNode root)
        {
            TreeNode res = root;
            int d = Depth(root);

            return Helper(root, d);



        }

        private int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int l = Depth(root.left);
            int r = Depth(root.right);
            return Math.Max(l, r) + 1;
        }

        private TreeNode Helper(TreeNode root, int d)
        {
            TreeNode res = null;
            if (root == null)
            {
                return null;
            }

            int l = Depth(root.left);
            int r = Depth(root.right);
            if (l == r && l == d - 1)
            {
                res = root;
            }
            else
            {
                res = Helper(root.left, d - 1);
                if (res == null)
                {
                    res = Helper(root.right, d - 1);
                }
            }

            return res;
        }
    }
}
