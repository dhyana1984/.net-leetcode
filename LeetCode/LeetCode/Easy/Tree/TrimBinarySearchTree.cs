using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{

  public class TrimBinarySearchTree
    {
    
        public TreeNode Solution(TreeNode root, int L, int R)
        {
            if (root == null)
                return null;

            if (root.val < L)
                return Solution(root.right, L, R);

            else if (root.val > R)
                return Solution(root.left, L, R);

            root.left = Solution(root.left, L, R);
            root.right = Solution(root.right, L, R);
            return root;
        }


    }
}
