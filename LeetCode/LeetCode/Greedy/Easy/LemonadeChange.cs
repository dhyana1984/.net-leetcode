using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Easy
{
    /*
     * 在柠檬水摊上，每一杯柠檬水的售价为 5 美元。

        顾客排队购买你的产品，（按账单 bills 支付的顺序）一次购买一杯。

        每位顾客只买一杯柠檬水，然后向你付 5 美元、10 美元或 20 美元。你必须给每个顾客正确找零，也就是说净交易是每位顾客向你支付 5 美元。

        注意，一开始你手头没有任何零钱。

        如果你能给每位顾客正确找零，返回 true ，否则返回 false 。

        示例 1：

        输入：[5,5,5,10,20]
        输出：true
        解释：
        前 3 位顾客那里，我们按顺序收取 3 张 5 美元的钞票。
        第 4 位顾客那里，我们收取一张 10 美元的钞票，并返还 5 美元。
        第 5 位顾客那里，我们找还一张 10 美元的钞票和一张 5 美元的钞票。
        由于所有客户都得到了正确的找零，所以我们输出 true。
        示例 2：

        输入：[5,5,10]
        输出：true
        示例 3：

        输入：[10,10]
        输出：false
        示例 4：

        输入：[5,5,10,10,20]
        输出：false
        解释：
        前 2 位顾客那里，我们按顺序收取 2 张 5 美元的钞票。
        对于接下来的 2 位顾客，我们收取一张 10 美元的钞票，然后返还 5 美元。
        对于最后一位顾客，我们无法退回 15 美元，因为我们现在只有两张 10 美元的钞票。
        由于不是每位顾客都得到了正确的找零，所以答案是 false。
 

        提示：

        0 <= bills.length <= 10000
        bills[i] 不是 5 就是 10 或是 20 


     */
    public class LemonadeChange
    {
        Dictionary<int, int> packageDict = new Dictionary<int, int>();
        public bool Solution(int[] bills)
        {
            for (var i = 0; i < bills.Length; i++)
            {
                if (!checkChanges(bills[i]))                                        //检查每一个bill，如果不满足则返回false
                    return false;
            }
            return true;                                                            //如果都满足则返回true
        }

        private bool checkChanges(int change)
        {
            if (change != 5 && (!packageDict.ContainsKey(5)))                       //如果当前的bill不等于5，并且从来没有收到过5块钱的bill，直接返回false
                return false;

            switch (change)
            {
                case 20:                                                            //如果当前收到20块钱
                    if (packageDict.ContainsKey(10) && packageDict[10] > 0)           //如果有10块则减去1个10块
                        packageDict[10] -= 1;
                    else if (packageDict.ContainsKey(5) && packageDict[5] > 3)      //如果没10块则减去2个5块
                        packageDict[5] -= 2;
                    else                                                            //如果又没10块又没5块返回false                 
                        return false;
                    packageDict[5] -= 1;                                            //最后减去1个5块，和上面相加总找回15块
                    break;
                case 10:                                                            //如果收到10块钱
                    if (!packageDict.ContainsKey(change))                           //10块钱钞票加1
                        packageDict[change] = 1;
                    else
                        packageDict[change] += 1;
                    packageDict[5] -= 1;                                            //5块钱钞票减一，表示找回5块
                    break;
                case 5:                                                             //如果收到5块钱    
                    if (!packageDict.ContainsKey(change))                           //5块钱钞票加1，不用找回
                        packageDict[change] = 1;
                    else
                        packageDict[change] += 1;
                    break;
            }


            if (packageDict.ContainsKey(5) && packageDict[5] < 0)               //如果5块钱钞票数量小于0，则表示没有足够的零钱找回，返回false
                return false;
            return true;
        }
    }
}
