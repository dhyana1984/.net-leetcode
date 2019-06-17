using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，其中所有的右节点要么是具有兄弟节点（拥有相同父节点的左节点）的叶节点，
     * 要么为空，将此二叉树上下翻转并将它变成一棵树， 原来的右节点将转换成左叶节点。返回新的根。

        例子:

        输入: [1,2,3,4,5]

            1
           / \
          2   3
         / \
        4   5

        输出: 返回二叉树的根 [4,5,2,#,#,3,1]

           4
          / \
         5   2
            / \
           3   1  


     */
    public class UpsideDownBinaryTree
    {

        public TreeNode Solution(TreeNode root)
        {

            /*
                根据题目描述，树中任何节点的右子节点若存在一定有左子节点，因此思路是向左遍历树进行转化；
                规律是：左子节点变父节点；父节点变右子节点；右子节点变左子节点。
                对于某节点root，修改root.left，root.right之前，需要将三者都存下来：
                root.left是下一轮递归的主节点；
                root是下一轮递归root的root.right；
                root.right是下一轮递归root的root.left。
                返回parent。
            */

            TreeNode root_left = null;
            TreeNode parent_right = null;
            TreeNode parent = null;
            while (root != null)
            {
                root_left = root.left;
                root.left = parent_right;
                parent_right = root.right;
                root.right = parent;
                parent = root;
                root = root_left;

            }
            return parent;
        }



    }
}
