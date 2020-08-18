/*1370
 * 给你一个字符串 s ，请你根据下面的算法重新构造字符串：

从 s 中选出 最小 的字符，将它 接在 结果字符串的后面。
从 s 剩余字符中选出 最小 的字符，且该字符比上一个添加的字符大，将它 接在 结果字符串后面。
重复步骤 2 ，直到你没法从 s 中选择字符。
从 s 中选出 最大 的字符，将它 接在 结果字符串的后面。
从 s 剩余字符中选出 最大 的字符，且该字符比上一个添加的字符小，将它 接在 结果字符串后面。
重复步骤 5 ，直到你没法从 s 中选择字符。
重复步骤 1 到 6 ，直到 s 中所有字符都已经被选过。
在任何一步中，如果最小或者最大字符不止一个 ，你可以选择其中任意一个，并将其添加到结果字符串。

请你返回将 s 中字符重新排序后的 结果字符串 。



示例 1：

输入：s = "aaaabbbbcccc"
输出："abccbaabccba"
解释：第一轮的步骤 1，2，3 后，结果字符串为 result = "abc"
第一轮的步骤 4，5，6 后，结果字符串为 result = "abccba"
第一轮结束，现在 s = "aabbcc" ，我们再次回到步骤 1
第二轮的步骤 1，2，3 后，结果字符串为 result = "abccbaabc"
第二轮的步骤 4，5，6 后，结果字符串为 result = "abccbaabccba"
 */

/**
 * @param {string} s
 * @return {string}
 */
var sortString = function (s) {
    //先正序排一遍
    const array = [...s].sort()
    let res = []
    //当s里面还有字符时，继续排
    while (array.length) {
        //用来存放当前s中唯一字符
        let mySet = new Set(array)
        //转成数组
        let tempArray = [...mySet]
        //先正序排列
        tempArray.sort()
        //对应题目步骤1，2，3, 正序把s中的排完
        for (let i = 0; i < tempArray.length; i++) {
            res.push(tempArray[i])
            array.splice(array.indexOf(tempArray[i]), 1)
        }
        //把s剩下的唯一化
        mySet = new Set(array)
        //然后倒序排列放入临时数组
        tempArray = [...mySet].reverse()
        //对应题目步骤4，5，6,倒序把s中的排完
        for (let i = 0; i < tempArray.length; i++) {
            if (array.length) {
                res.push(tempArray[i])
                array.splice(array.indexOf(tempArray[i]), 1)
            }
        }
    }
    //直到s没有字符了，返回结果
    return res.join("")
