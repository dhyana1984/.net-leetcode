using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
  
    public class FindClosestLeaf
    {

        int? currentMinDistance = int.MaxValue;
        int currentValue = int.MaxValue;

        public int Solution(TreeNode root, int k)
        {
            GetTargetDistance(root, k);
            return currentValue;
        }

        private int? GetTargetDistance(TreeNode node, int? target)
        {
            if (node == null || (node.left == null && node.right == null && node.val != target))
            {
                return null;
            }

            if (node.val == target)
            {
                GetMinDistanceResult(node, 0);
                return 0;
            }

            int? leftDistance = GetTargetDistance(node.left, target);
            int? rightDistance = GetTargetDistance(node.right, target);
            if (leftDistance == null && rightDistance == null)
            {
                return null;
            }

            int? distance = leftDistance == null ? rightDistance : leftDistance;
            GetMinDistanceResult(node, distance + 1);
            return distance;
        }

        private void GetMinDistanceResult(TreeNode node, int? distance)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null && distance < currentMinDistance)
            {
                currentMinDistance = distance;
                currentValue = node.val;
            }

            GetMinDistanceResult(node.left, distance + 1);
            GetMinDistanceResult(node.right, distance + 1);
        }




    }
}
