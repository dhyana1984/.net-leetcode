using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个二叉搜索树和一个目标结果，如果 BST 中存在两个元素且它们的和等于给定的目标结果，则返回 true。

        案例 1:

        输入: 
            5
           / \
          3   6
         / \   \
        2   4   7

        Target = 9

        输出: True
 

        案例 2:

        输入: 
            5
           / \
          3   6
         / \   \
        2   4   7

        Target = 28

        输出: False
     */
    public class FindTarget
    {
        public bool Solution(TreeNode root, int k)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null) return false;
            List<int> list = new List<int>();
            ConvertTreeToList(root, list);
            if (list[list.Count - 1] + list[list.Count - 2] < k || list[0] + list[1] > k)
                return false;
            /*for(int i=0;i<list.Count-1;i++)
                        for(int j=i+1;j<list.Count;j++)
                            if(list[i]+list[j]==k)
                                return true;*/
            int begin = 0;
            int end = list.Count - 1;
            while (begin < end)
            {
                int result = list[begin] + list[end];
                if (result == k)
                    return true;
                else if (result < k)
                    begin++;
                else
                    end--;
            }
            return false;

        }

        private void ConvertTreeToList(TreeNode root, List<int> list)
        {
            if (root == null)
                return;

            ConvertTreeToList(root.left, list);

            list.Add(root.val);

            ConvertTreeToList(root.right, list);
        }
    }
}
