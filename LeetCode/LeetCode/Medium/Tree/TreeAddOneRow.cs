using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，根节点为第1层，深度为 1。在其第 d 层追加一行值为 v 的节点。

        添加规则：给定一个深度值 d （正整数），针对深度为 d-1 层的每一非空节点 N，为 N 创建两个值为 v 的左子树和右子树。

        将 N 原先的左子树，连接为新节点 v 的左子树；将 N 原先的右子树，连接为新节点 v 的右子树。

        如果 d 的值为 1，深度 d - 1 不存在，则创建一个新的根节点 v，原先的整棵树将作为 v 的左子树。

        示例 1:

        输入: 
        二叉树如下所示:
               4
             /   \
            2     6
           / \   / 
          3   1 5   

        v = 1

        d = 2

        输出: 
               4
              / \
             1   1
            /     \
           2       6
          / \     / 
         3   1   5   

        示例 2:

        输入: 
        二叉树如下所示:
              4
             /   
            2    
           / \   
          3   1    

        v = 1

        d = 3

        输出: 
              4
             /   
            2
           / \    
          1   1
         /     \  
        3       1


     */

    public class TreeAddOneRow
    {
        public TreeNode Solution(TreeNode root, int v, int d)
        {
            if (d == 1)
            {
                TreeNode t = new TreeNode(v);
                t.left = root;
                return t;
            }
            var queue = new Queue<TreeNode>();
            var flag = true;
            queue.Enqueue(root);
            int count;
            int level = 1;
            TreeNode node = null;
            while (queue.Any() && flag)
            {
                count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    node = queue.Dequeue();
                    if (d - 1 == level)
                    {
                        var tempLeft = node.left;
                        var tempRight = node.right;
                        node.left = new TreeNode(v);
                        node.right = new TreeNode(v);
                        node.left.left = tempLeft;
                        node.right.right = tempRight;

                    }
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);

                }
                level++;
            }
            return root;

        }
    }
}
