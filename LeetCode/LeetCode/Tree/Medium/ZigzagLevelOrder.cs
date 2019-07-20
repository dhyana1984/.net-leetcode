using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 给定一个二叉树，返回其节点值的锯齿形层次遍历。（即先从左往右，再从右往左进行下一层遍历，以此类推，层与层之间交替进行）。

        例如：
        给定二叉树 [3,9,20,null,null,15,7],

            3
           / \
          9  20
            /  \
           15   7
        返回锯齿形层次遍历如下：

        [
          [3],
          [20,9],
          [15,7]
        ]


     */
    public class ZigzagLevelOrder
    {
        public IList<IList<int>> Solution(TreeNode root)
        {
            var list = new List<IList<int>>();
            if (root == null)
                return list;
            var queueTree = new Queue<TreeNode>();
            var stack = new Stack<int>(); //用来存放偶数层的节点，保证偶数层节点遍历顺序从右到左
            var queue = new Queue<int>(); //用来存放奇数层节点，保证奇数层节点遍历顺序从左到右
            queueTree.Enqueue(root);
            var node = new TreeNode(0);
            var count = 0;
            var level = 1;
            while (queueTree.Any())
            {
                count = queueTree.Count;
                var levelList = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    node = queueTree.Dequeue();
                    if (node.left != null)
                        queueTree.Enqueue(node.left);
                    if (node.right != null)
                        queueTree.Enqueue(node.right);

                    if (level % 2 != 0)
                        queue.Enqueue(node.val); //奇数层的节点进栈
                    else
                        stack.Push(node.val);    //偶数层的节点进队列
                }

                //层次遍历结束以后将队列或者栈里面的结果存到结果集
                if (level % 2 != 0)
                {
                    while (queue.Any())
                    {
                        levelList.Add(queue.Dequeue());
                    }
                }
                else
                {
                    while (stack.Any())
                    {
                        levelList.Add(stack.Pop());
                    }
                }
      
                level++;
                list.Add(levelList);
            }



            return list;


        }



    }


}

