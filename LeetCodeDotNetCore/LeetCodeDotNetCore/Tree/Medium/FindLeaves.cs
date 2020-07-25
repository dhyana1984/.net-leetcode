using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给你一棵完全二叉树，请按以下要求的顺序收集它的全部节点：

        依次从左到右，每次收集并删除所有的叶子节点
        重复如上过程直到整棵树为空
        示例:

        输入: [1,2,3,4,5]
  
                  1
                 / \
                2   3
               / \     
              4   5    

        输出: [[4,5,3],[2],[1]]


     */

    public class FindLeaves
    {
        IList<IList<int>> result = new List<IList<int>>();
        Dictionary<int, IList<int>> dict = new Dictionary<int, IList<int>>();
        public IList<IList<int>> Solution(TreeNode root)
        {
            if (root == null)
                return result;
            PostOrder(root);
            foreach (var item in dict)
            {
                result.Add(item.Value);
            }
            return result;
        }

        private int PostOrder(TreeNode node)
        {
            int pos = 0;
            if (node.left != null)
                pos = PostOrder(node.left) + 1;
            if (node.right != null)
                pos = Math.Max(PostOrder(node.right) + 1, pos);
            if(dict.ContainsKey(pos))
                dict[pos].Add(node.val);
            else
            {
                dict[pos] = new List<int> { node.val};
            }
            return pos;
        }
    }
}
