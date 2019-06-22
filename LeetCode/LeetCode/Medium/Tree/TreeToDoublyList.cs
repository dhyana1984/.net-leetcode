using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 将一个二叉搜索树就地转化为一个已排序的双向循环链表。可以将左右孩子指针作为双向循环链表的前驱和后继指针。
     */

    public class TreeToDoublyList
    {
        List<Node> list = new List<Node>();
        public Node Solution(Node root)
        {
            if (root == null)
                return root;
            InOrder(root);

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                    list[i].right = list[i + 1];
                else
                {
                    list[i].right = list[0];
                }
                if (i != 0)
                    list[i].left = list[i - 1];
                else
                    list[i].left = list[list.Count - 1];
            }
            return list[0];

        }


        private void InOrder(Node node)
        {
            if (node == null)
                return;
            InOrder(node.left);
            list.Add(node);
            InOrder(node.right);
        }
    }
}
