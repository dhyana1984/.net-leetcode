using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree.NodesModel
{
    public class LinkNode
    {
        public int val;
        public LinkNode left;
        public LinkNode right;

        public LinkNode() { }
        public LinkNode(int _val, LinkNode _left, LinkNode _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}
