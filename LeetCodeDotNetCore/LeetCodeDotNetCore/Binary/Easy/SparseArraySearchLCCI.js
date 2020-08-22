/*
 * 稀疏数组搜索。有个排好序的字符串数组，其中散布着一些空字符串，编写一种方法，找出给定字符串的位置。

示例1:

 输入: words = ["at", "", "", "", "ball", "", "", "car", "", "","dad", "", ""], s = "ta"
 输出：-1
 说明: 不存在返回-1。
示例2:

 输入：words = ["at", "", "", "", "ball", "", "", "car", "", "","dad", "", ""], s = "ball"
 输出：4
提示:

words的长度在[1, 1000000]之间
 */

/**
 * @param {string[]} words
 * @param {string} s
 * @return {number}
 */
var findString = function (words, s) {
    const n = words.length
    let left = 0, right = n - 1
    while (left <= right) {
        //如果左边界是空，向右移一位
        while (words[left] === "") left++
        //如果右边界是空，向左移一位
        while (words[right] === "") right--
        let mid = Math.floor((left + right) / 2)
        //如果中位是空，且中位大于left，则向左移
        //也可以写成while(words[mid]==="" && mid <right) mid++
        while (words[mid] === "" && mid > left) mid--
        //以下是常规二分法处理
        if (s === words[mid]) {
            return mid
        } else if (s < words[mid]) {
            right = mid - 1
        } else {
            left = mid + 1
        }
    }
    return -1

};