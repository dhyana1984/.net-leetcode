/**
 * 367
 * 给定一个正整数 num，编写一个函数，如果 num 是一个完全平方数，则返回 True，否则返回 False。

    说明：不要使用任何内置的库函数，如  sqrt。

    示例 1：

    输入：16
    输出：True
    示例 2：

    输入：14
    输出：False

 */


/**
 * @param {number} num
 * @return {boolean}
 */
var isPerfectSquare = function (num) {
    if (num === 1) return true
    if (num <= 3) return false
    let left = 1, right = Math.floor(num / 2)
    while (left <= right) {
        let mid = Math.floor((left + right) / 2)
        if (mid * mid === num) return true
        if (mid * mid < num) {
            left = mid + 1
        } else {
            right = mid - 1
        }
    }

    return false
};

/**
 * @param {number} num
 * @return {boolean}
 */
//1
//4 = 1 + 3
//9 = 1 + 3 + 5
//16= 1 + 3 + 5 +7
//...
var isPerfectSquare = function (num) {
    let num1 = 1;
    while (num > 0) {
        num -= num1;
        num1 += 2;
    }
    return num == 0;


};