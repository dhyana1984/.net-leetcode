using LeetCode.Easy;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个有 N 个结点的二叉树的根结点 root，树中的每个结点上都对应有 node.val 枚硬币，并且总共有 N 枚硬币。

        在一次移动中，我们可以选择两个相邻的结点，然后将一枚硬币从其中一个结点移动到另一个结点。(移动可以是从父结点到子结点，或者从子结点移动到父结点。)。

        返回使每个结点上只有一枚硬币所需的移动次数。


     */
    public class DistributeTreeCoins
    {
        int res = 0;
        public int Solution(TreeNode root)
        {
            MoveTheCoinPostOrder(root, root);
            return res;
        }
        //后序遍历
        private void MoveTheCoinPostOrder(TreeNode node, TreeNode root)
        {
            if (node == null)
                return;
            MoveTheCoinPostOrder(node.left, node);
            MoveTheCoinPostOrder(node.right, node);
            if (node.val == 0)                            //如果当前节点金币数是0
            {
                root.val -= 1;                            //父节点移动一个金币过来
                res += 1;                                 //移动次数累加1
            }
            else if (node.val < 0 || node.val > 1)        //如果当前节点金币数小于0个(可能之前移动给子节点了)或者大于1个
            {
                var temp = node.val;                      //保存当前节点金币数
                root.val += temp - 1;                     //父节点的金币数累加temp-1个
                                                          //（注意，如果temp可能为负数，那么父节点实际上是减去|temp+1|个金币
                                                          //如果此时temp是正数,父节点是加上temp-1个金币
                res += temp < 0 ? 1 - temp : temp - 1;    //累加移动次数（当temp<0时 1-temp=|temp+1|）
            }
        }
    }
}
