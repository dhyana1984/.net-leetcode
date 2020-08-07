
/**
 * 1518
 * 小区便利店正在促销，用 numExchange 个空酒瓶可以兑换一瓶新酒。你购入了 numBottles 瓶酒。

    如果喝掉了酒瓶中的酒，那么酒瓶就会变成空的。

    请你计算 最多 能喝到多少瓶酒。


    示例 1：

    输入：numBottles = 9, numExchange = 3
    输出：13
    解释：你可以用 3 个空酒瓶兑换 1 瓶酒。
    所以最多能喝到 9 + 3 + 1 = 13 瓶酒。


 */
var numWaterBottles = function (numBottles, numExchange) {
    let fullBottles = numBottles
    let drunk = 0
    while (fullBottles >= numExchange) { //只要满瓶足够多，就可以换
        //喝掉numExchange瓶，换1瓶
        fullBottles = fullBottles - numExchange + 1
        //喝掉的瓶数+numExchange
        drunk += numExchange
    }
    //最后手上不够换，但是仍然可能有满瓶，要喝掉再加上已经喝掉的
    return drunk + fullBottles
};