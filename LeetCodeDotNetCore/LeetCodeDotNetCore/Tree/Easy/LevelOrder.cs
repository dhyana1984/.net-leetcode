using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /// <summary>
    /// N叉树
    /// </summary>
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    /*
     * 给定一个 N 叉树，返回其节点值的层序遍历。 (即从左到右，逐层遍历)。

            例如，给定一个 3叉树 :

            返回其层序遍历:

            [
                 [1],
                 [3,2,4],
                 [5,6]
            ]
 
     */
    public class LevelOrder
        {
            public IList<IList<int>> Solution(Node root)
            {
            if (root == null)
                return new List<IList<int>>();
            var resultList = new List<IList<int>>();
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var list = new List<int>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.children != null)
                        for (int j = 0; j < node.children.Count; j++)
                            if (node.children[j] != null)
                                queue.Enqueue(node.children[j]);
                }
                resultList.Add(list);
            }
            return resultList;
        }
        }
   
}
