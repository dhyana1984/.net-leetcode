using System;
namespace LeetCodeDotNetCore.DP.Medium
{
    /*
     * 给你一根长度为 n 的绳子，请把绳子剪成整数长度的 m 段（m、n都是整数，n>1并且m>1），每段绳子的长度记为 k[0],k[1]...k[m-1] 。请问 k[0]*k[1]*...*k[m-1] 可能的最大乘积是多少？例如，当绳子的长度是8时，我们把它剪成长度分别为2、3、3的三段，此时得到的最大乘积是18。

        示例 1：

        输入: 2
        输出: 1
        解释: 2 = 1 + 1, 1 × 1 = 1
        示例 2:

        输入: 10
        输出: 36
        解释: 10 = 3 + 3 + 4, 3 × 3 × 4 = 36
        提示：

        2 <= n <= 58


     */
    public class CutRope
    {
        public int Solution(int n)
        {
            var dp = new int[n + 1];
            //绳子的长度等于0时，切割后最大长度是0
            //绳子长度是1和2时，切割后最大长度是1
            dp[1] = 1;
            dp[2] = 1;
            //从绳子长度为3时开始遍历
            for (var i = 3; i < n + 1; i++)
                //切下来的长度是j，那么还剩下的长度是i-j
                for (var j = 0; j < i; j++)
                {
                    //长度是i的绳子，切去j长度，还剩下i-j长度
                    //此时需要比对是不切的时候长还是切了j以后长Math.Max(dp[i], 切了j以后的长度)
                    //切了j以后的长度又可以表示为是i-j是最后一段了还是i-j还可以继续切，所以要找到两种情况的最大值，即Math.Max(j * (i - j), j * dp[i - j])
                    dp[i] = Math.Max(dp[i], Math.Max(j * (i - j), j * dp[i - j]));
                }

            return dp[n];
        }
    }
}
