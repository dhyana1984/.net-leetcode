using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
   public class GetMinimumDifference
    {
        List<int> list = new List<int>();
        public int Solution(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode node;
            List<int> list = new List<int>();
            list.Add(root.val);
            while (queue.Any())
            {
                node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    list.Add(node.left.val);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    list.Add(node.right.val);
                }
            }
            int result = int.MaxValue;
            for (int i = 0; i < list.Count - 1; i++)
                for (int j = i + 1; j < list.Count; j++)
                {
                    result = Math.Min(result, Math.Abs(list[i] - list[j]));
                    if (result == 1)
                        return 1;
                }

            return result;



        }

    

    }
}
