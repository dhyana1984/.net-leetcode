using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy.Tree
{
    /*
     * 我们可以为二叉树 T 定义一个翻转操作，如下所示：选择任意节点，然后交换它的左子树和右子树。

        只要经过一定次数的翻转操作后，能使 X 等于 Y，我们就称二叉树 X 翻转等价于二叉树 Y。

        编写一个判断两个二叉树是否是翻转等价的函数。这些树由根节点 root1 和 root2 给出。

。
     */

    public class FlipEquivBT
    {

        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2 == null;
            if (root2 == null)
                return root1 == null;
            if (root1.val != root2.val)
                return false;

            return FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left)
                  || FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right);
        }


    }
}
