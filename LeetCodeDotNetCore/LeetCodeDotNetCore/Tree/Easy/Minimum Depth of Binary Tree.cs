using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    public class Minimum_Depth_of_Binary_Tree
    {
        /*
         * 给定一个二叉树，找出其最小深度。

        最小深度是从根节点到最近叶子节点的最短路径上的节点数量。

        说明: 叶子节点是指没有子节点的节点。

        示例:

        给定二叉树 [3,9,20,null,null,15,7],

        3
        / \
        9  20
        /  \
        15   7
        返回它的最小深度  2.
         */
        public int Solution(TreeNode root)
            {
                //遍历解答 

                //if (root == null)
                //    return 0;
                //Queue<TreeNode> queue = new Queue<TreeNode>();
                //queue.Enqueue(root);
                //int count;
                //int level = 1;
                //while (queue.Any())
                //{
                //    count = queue.Count;
                //    for (int i = 0; i < count; i++)
                //    {
                //        TreeNode node = queue.Dequeue();
                //        if (node.left != null)
                //            queue.Enqueue(node.left);
                //        if (node.right != null)
                //            queue.Enqueue(node.right);
                //        if (node.right == null && node.left == null)
                //            return level;

                //    }
                //    level++;
                //}

                //return 1;

                //递归解答 
                if (root == null)
                    return 0;
        
                else
                {
                    
                         
                    int left = Solution(root.left);
                    int right = Solution(root.right);
                    if (left == 0)
                        return right + 1;
                    else if(right ==0)
                        return left + 1;
                    else
                        return Math.Min(left, right) + 1;
                 
                }




            }



        
    }
}
