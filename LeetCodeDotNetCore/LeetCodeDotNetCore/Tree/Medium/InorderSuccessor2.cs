using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一棵二叉搜索树和其中的一个节点，找到该节点在树中的中序后继。

        一个结点 p 的中序后继是键值比 p.val大所有的结点中键值最小的那个。

        你可以直接访问结点，但无法直接访问树。每个节点都会有其父节点的引用。


     */
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node parent;
    }

    public class InorderSuccessor2
    {
        Node result = null;
        bool flag = false;
        public Node Solution(Node x)
        {
            if (x == null) return null;
            Node root = x;
            while (root.parent != null)
            {
                root = root.parent;
            }
            InOrder(root, x);
            return result;
        }


        private void InOrder(Node node, Node target)
        {
            if (node == null)
                return;
            InOrder(node.left, target);
            if (flag && result == null)
                result = node;
            if (node == target)
                flag = true;

            InOrder(node.right, target);
        }
    }
}
