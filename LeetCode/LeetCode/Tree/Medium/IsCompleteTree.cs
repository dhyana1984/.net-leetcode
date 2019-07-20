using LeetCode.Easy;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium.Tree
{
    /*
     * 
     * 给定一个二叉树，确定它是否是一个完全二叉树。

        百度百科中对完全二叉树的定义如下：

        若设二叉树的深度为 h，除第 h 层外，其它各层 (1～h-1) 的结点数都达到最大个数，第 h 层所有的结点都连续集中在最左边，这就是完全二叉树。（注：第 h 层可能包含 1~ 2h 个节点。）


     */


    public class IsCompleteTree
    {
        public bool Solution(TreeNode root)
        {
            if (root == null) return false;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool flag = false;
            while (queue.Any())
            {
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {

                    var node = queue.Dequeue();
                    //出现第一个null节点，记录。如果出现null节点后还出现了非Null节点，表示节点不是全部都靠左，返回false
                    if (node == null && !flag)
                    {
                        flag = true;
                    }
                    else if (node != null && flag)
                    {
                        return false;
                    }
                    else if (node != null && !flag)
                    {
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }


                }

            }
            return true;
        }
    }
}
