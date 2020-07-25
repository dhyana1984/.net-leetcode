using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helper
{
    public static class TreeGenerater
    {
        //通过所给list生成二叉树
        public static TreeNode GetRoot(List<int?> list)
        {

            TreeNode root = new TreeNode(Convert.ToInt16(list[0]));
            if(list.Count>1)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                Queue<TreeNode> queuekRoot = new Queue<TreeNode>();
                queuekRoot.Enqueue(root);
                for (int i = 1; i <list.Count; i++)
                {
                    queue.Enqueue(new TreeNode(Convert.ToInt16(list[i])));
                }


     
                while (queuekRoot.Any())
                {
                        TreeNode node = queuekRoot.Dequeue();
                        if (queue.Any())
                            node.left = queue.Dequeue();
                 
                        if (queue.Any())
                            node.right = queue.Dequeue();
                        if (node.left != null)
                            queuekRoot.Enqueue(node.left);
                        if (node.right != null)
                            queuekRoot.Enqueue(node.right);
                }
            }
            return root;
        }
    }
}
