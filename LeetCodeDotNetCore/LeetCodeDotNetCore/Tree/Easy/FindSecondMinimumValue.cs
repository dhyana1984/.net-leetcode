using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个非空特殊的二叉树，每个节点都是正数，并且每个节点的子节点数量只能为 2 或 0。如果一个节点有两个子节点的话，那么这个节点的值不大于它的子节点的值。 

         给出这样的一个二叉树，你需要输出所有节点中的第二小的值。如果第二小的值不存在的话，输出 -1 。

         示例 1:

         输入: 
             2
            / \
           2   5
              / \
             5   7

         输出: 5
         说明: 最小的值是 2 ，第二小的值是 5 。
         示例 2:

         输入: 
             2
            / \
           2   2

         输出: -1
         说明: 最小的值是 2, 但是不存在第二小的值。
     */
    public class FindSecondMinimumValue
    {
 
        public int Solution(TreeNode root)
        {
            if (root == null) return -1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int rootValue = root.val;
            int result = rootValue;
            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null)
                {
                    if (node.left.val != node.val && node.right.val != node.val)
                    {
                        result = Math.Min(node.left.val, node.right.val);
                        break;
                    }
                    else if (node.left.val == node.val)
                    {
                        if (result == rootValue)
                            result = node.right.val;
                        else if(node.right.val> rootValue)
                            result = Math.Min(result, node.right.val);
                    }
                    else if (node.right.val == node.val)
                    {
                        if (result == rootValue)
                            result = node.left.val;
                        else if(node.left.val > rootValue)
                            result = Math.Min(result, node.left.val);
                    }
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }

            }
            if (result == rootValue)
                return -1;
            else return result;
        }


    }


}
