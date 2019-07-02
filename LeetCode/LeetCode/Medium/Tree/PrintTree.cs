using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 在一个 m*n 的二维字符串数组中输出二叉树，并遵守以下规则：

        行数 m 应当等于给定二叉树的高度。
        列数 n 应当总是奇数。
        根节点的值（以字符串格式给出）应当放在可放置的第一行正中间。根节点所在的行与列会将剩余空间划分为两部分（左下部分和右下部分）。你应该将左子树输出在左下部分，右子树输出在右下部分。左下和右下部分应当有相同的大小。即使一个子树为空而另一个非空，你不需要为空的子树输出任何东西，但仍需要为另一个子树留出足够的空间。然而，如果两个子树都为空则不需要为它们留出任何空间。
        每个未使用的空间应包含一个空的字符串""。
        使用相同的规则输出子树。
        示例 1:

        输入:
             1
            /
           2
        输出:
        [["", "1", ""],
         ["2", "", ""]]
        示例 2:

        输入:
             1
            / \
           2   3
            \
             4
        输出:
        [["", "", "", "1", "", "", ""],
         ["", "2", "", "", "", "3", ""],
         ["", "", "4", "", "", "", ""]]
        示例 3:

        输入:
              1
             / \
            2   5
           / 
          3 
         / 
        4 
        输出:
        [["",  "",  "", "",  "", "", "", "1", "",  "",  "",  "",  "", "", ""]
         ["",  "",  "", "2", "", "", "", "",  "",  "",  "",  "5", "", "", ""]
         ["",  "3", "", "",  "", "", "", "",  "",  "",  "",  "",  "", "", ""]
         ["4", "",  "", "",  "", "", "", "",  "",  "",  "",  "",  "", "", ""]]

     */
    public class PrintTree
    {
        public IList<IList<string>> Solution(TreeNode root)
        {
            var resultList = new List<IList<string>>();
            
            int count = Get_level(root);
            int column = Convert.ToInt16(Math.Pow(2, count)) - 1;
            for (int i = 0; i < count; i++)
            {
                var list = new List<string>();
                for (int k = 0; k < column; k++)
                    list.Add("");
                resultList.Add(list);
            }
            
            ResultHelper(root, resultList, 0, 0, column);
            return resultList;
        }

        private void ResultHelper(TreeNode root,
                                                  IList<IList<string>> list,
                                                  int row,
                                                  int start,
                                                  int end)
        {
            if (end <= start || root == null)
                return;
            else if (end - start == 1)
                list[row][start] = root.val.ToString();
            else
            {
                int mid = (end - start) / 2 + start;
                list[row][mid] = root.val.ToString();
                ResultHelper(root.left, list, row + 1, start, mid);
                ResultHelper(root.right, list, row + 1, mid + 1, end);
            }

        }

        private int Get_level(TreeNode node)
        {
            if (node == null)
                return 0;
            else
                return Math.Max(Get_level(node.left), Get_level(node.right)) + 1;
        }
    }
}
