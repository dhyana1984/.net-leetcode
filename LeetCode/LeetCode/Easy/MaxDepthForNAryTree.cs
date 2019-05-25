using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个 N 叉树，找到其最大深度。

    最大深度是指从根节点到最远叶子节点的最长路径上的节点总数。
     */
    public class MaxDepthForNAryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;

            return FindNode(root.children);


        }

        private int FindNode(IList<Node> children)
        {
            if (children == null)
                return 0;
            int max = 0;
            for (int i = 0; i < children.Count; i++)
            {

                max = Math.Max(FindNode(children[i].children), max);
            }

            return max + 1;
        }
    }
}
