using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 考虑一颗二叉树上所有的叶子，这些叶子的值按从左到右的顺序排列形成一个 叶值序列 。



        举个例子，如上图所示，给定一颗叶值序列为 (6, 7, 4, 9, 8) 的树。

        如果有两颗二叉树的叶值序列是相同，那么我们就认为它们是 叶相似 的。

        如果给定的两个头结点分别为 root1 和 root2 的树是叶相似的，则返回 true；否则返回 false 。
     */
    public class LeafSimilar
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        public bool Solution(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;
            InOrder(root1, list1);
            InOrder(root2, list2);
            if (list1.Count != list2.Count)
                return false;

            return Enumerable.SequenceEqual(list1, list2); ;
        }


        private void InOrder(TreeNode t, List<int> list)
        {

            if (t == null)
                return;
            InOrder(t.left, list);
            if (t.left == null && t.right == null)
                list.Add(t.val);
            InOrder(t.right, list);


        }




    }
}
