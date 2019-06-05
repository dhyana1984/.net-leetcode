using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 在二叉树中，根节点位于深度 0 处，每个深度为 k 的节点的子节点位于深度 k+1 处。

        如果二叉树的两个节点深度相同，但父节点不同，则它们是一对堂兄弟节点。

        我们给出了具有唯一值的二叉树的根节点 root，以及树中两个不同节点的值 x 和 y。

        只有与值 x 和 y 对应的节点是堂兄弟节点时，才返回 true。否则，返回 false。
     */
    public class IsCousinsNode
    {
        public bool Solution(TreeNode root, int x, int y)
        {

            var queue = new Queue<TreeNode>();
            Dictionary<TreeNode, TreeNode> dict = new Dictionary<TreeNode, TreeNode>();
            dict[root] = root;
            queue.Enqueue(root);
            int count = 0;
            int level = 1;
            int level_X = x;
            int level_Y = y;
            TreeNode node_X = new TreeNode(x);
            TreeNode node_y = new TreeNode(y);
            TreeNode node;

            while (queue.Any())
            {
                count = queue.Count;


                for (int i = 0; i < count; i++)
                {
                    node = queue.Dequeue();

                    if (node.val == x)
                    {
                        level_X = level;
                        node_X = node;
                    }
                    else if (node.val == y)
                    {
                        level_Y = level;
                        node_y = node;
                    }
                    if (level_X == level_Y && dict.ContainsKey(node_X) && dict.ContainsKey(node_y) && dict[node_X] != dict[node_y])
                        return true;

                    if (node.left != null)
                    {
                        dict[node.left] = node;
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        dict[node.right] = node;
                        queue.Enqueue(node.right);
                    }
                }
                level += 1;
            }

            return false;

        }
    }
}
