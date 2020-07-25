using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
 
   public class Str2tree
    {
        /*
         * 你需要从一个包括括号和整数的字符串构建一棵二叉树。

            输入的字符串代表一棵二叉树。它包括整数和随后的0，1或2对括号。整数代表根的值，一对括号内表示同样结构的子树。

            若存在左子结点，则从左子结点开始构建。

            示例:

            输入: "4(2(3)(1))(6(5))"
            输出: 返回代表下列二叉树的根节点:

                   4
                 /   \
                2     6
               / \   / 
              3   1 5   
 

            注意:

            输入字符串中只包含 '(', ')', '-' 和 '0' ~ '9' 
            空树由 "" 而非"()"表示。


         */
        public TreeNode Solution(string s)
        {
            if (s.Length == 0)
                return null;
            var index = s.IndexOf('(');

            var rootVal = index < 0 ? int.Parse(s) : int.Parse(s.Substring(0, index));
            var root = new TreeNode(rootVal);
            int length = s.Length;
            int brackets = 0;
            var start = index;
            if (index > 0)
                for (int i = start; i < length; i++)
                {
                    {
                        if (s[i] == '(')
                            ++brackets;
                        else if (s[i] == ')')
                            --brackets;

                        if (brackets == 0 && start == index)
                        {
                            /*
                             * start + 1是第一个左括号"("的后一位，即左子树的根
                             * i - start - 1是对应第一个左括号"("的闭合右括号")"
                             * s.Substring(start + 1, i - start - 1)的意思是将当前根节点去掉并把根节点后的左括号和最后一个闭合右括号去掉
                             * 然后作为左子树递归
                             */
                            root.left = Solution(s.Substring(start + 1, i - start - 1)); 
                            start = i + 1;
                        }
                        else if (brackets == 0)
                        {
                            root.right = Solution(s.Substring(start + 1, i - start - 1));
                        }
                    }
                }
            return root;



        }
    }
}
