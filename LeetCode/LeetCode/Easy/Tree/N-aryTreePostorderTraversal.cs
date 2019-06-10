using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个 N 叉树，返回其节点值的后序遍历。
     */
    public class N_aryTreePostorderTraversal
    {
        public IList<int> Postorder(Node root)
        {
            IList<int> resultList = new List<int>();
            if (root != null)
            {
                Recursive(root.children, resultList);
                resultList.Add(root.val);
            }
            return resultList;
        }

        private void Recursive(IList<Node> children, IList<int> resultList)
        {
            if (children == null) return;
            for (int i = 0; i < children.Count; i++)
            {
                Recursive(children[i].children, resultList);
                resultList.Add(children[i].val);
            }

        }
    }
}
