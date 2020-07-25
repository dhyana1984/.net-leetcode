using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个所有节点为非负值的二叉搜索树，求树中任意两节点的差的绝对值的最小值。

        示例 :

        输入:

           1
            \
             3
            /
           2

        输出:
        1

        解释:
        最小绝对差为1，其中 2 和 1 的差的绝对值为 1（或者 2 和 3）。
        注意: 树中至少有2个节点。
     */
    public class GetMinimumDifference
    {


        //List<int> list = new List<int>();
        int result = int.MaxValue;
        TreeNode last = null;
        public int Solution(TreeNode root)
        {
            //遍历解法
            //    Queue<TreeNode> queue = new Queue<TreeNode>();
            //    queue.Enqueue(root);
            //    TreeNode node;
            //    List<int> list = new List<int>();
            //    list.Add(root.val);
            //    while (queue.Any())
            //    {
            //        node = queue.Dequeue();

            //        if (node.left != null)
            //        {
            //            queue.Enqueue(node.left);
            //            list.Add(node.left.val);
            //        }
            //        if (node.right != null)
            //        {
            //            queue.Enqueue(node.right);
            //            list.Add(node.right.val);
            //        }
            //    }
            //    int result = int.MaxValue;
            //    for (int i = 0; i < list.Count - 1; i++)
            //        for (int j = i + 1; j < list.Count; j++)
            //        {
            //            result = Math.Min(result, Math.Abs(list[i] - list[j]));
            //            if (result == 1)
            //                return 1;
            //        }

            //    return result;


            //递归解法
            InOrder(root);

            return result;

        }
        public void InOrder(TreeNode tree)
        {
            if (tree == null)
                return;
            InOrder(tree.left);

            if (last != null)
                result = Math.Min(result, Math.Abs(tree.val - last.val));

            last = tree;

            InOrder(tree.right);
        }


    }
}
