using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{

    public class PathInZigZagTree
    {
        public IList<int> Solution(int label)
        {
            IList<int> res = new List<int>();
            var queue = new Queue<TreeNode>();
            int count = 1;
            int level = 1;
            var root = new TreeNode(1);
            queue.Enqueue(root);
            TreeNode node = null;
            var flag = true;
            var dict = new Dictionary<TreeNode, TreeNode>();
            var target = new TreeNode(1);
            while (flag)
            {
                count = queue.Count;
                for (int i=0;i<count;i++)
                {
                    node = queue.Dequeue();
                    if (node.val == label)
                    {
                        target = node;
                        res.Add(node.val);
                        flag = false;
                        break;
                    }
                    TreeNode left = new TreeNode(node.val * 2);
                    dict[left] = node;
                    TreeNode right = new TreeNode(node.val * 2 + 1);
                    dict[right] = node;
                    if (level%2==0)
                    {

                        queue.Enqueue(left);
                        queue.Enqueue(right);
                    }
                    else
                    {
                        queue.Enqueue(right);
                        queue.Enqueue(left);

                    }
                }
                if (!flag)
                    break;
                level++;
            }
            while(dict.ContainsKey(target))
            {
                res.Insert(0, dict[target].val);
                target = dict[target];
            }

            return res;
        }
    }
}
