using LeetCode.Easy;

namespace LeetCode.Medium.Tree
{


    public class PruneTree
    {
        /*
         * 给定二叉树根结点 root ，此外树的每个结点的值要么是 0，要么是 1。

            返回移除了所有不包含 1 的子树的原二叉树。

            ( 节点 X 的子树为 X 本身，以及所有 X 的后代。)

            示例1:
            输入: [1,null,0,0,1]
            输出: [1,null,0,null,1]


         */
        public TreeNode Solution(TreeNode root)
        {

            PostOrder(root, root);
            return root;
        }

        private void PostOrder(TreeNode node, TreeNode root)
        {
            if (node == null)
                return;
            //后序递归遍历树
            PostOrder(node.left, node);

            PostOrder(node.right, node);
            if (node.val == 0 && node.left == null && node.right == null) //如果递归到叶子节点并且值等于0
            {
                if (root.left == node)                                 //如果是左子节点，剪掉左子树
                    root.left = null;
                if (root.right == node)                                //如果是右子节点。剪掉右子树
                    root.right = null;
                if (root == node)                                      //如果是根节点本身，剪掉根节点
                    root = null;

            }

        }
    }
}
