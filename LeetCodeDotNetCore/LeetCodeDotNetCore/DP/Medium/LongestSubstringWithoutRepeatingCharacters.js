
/**
 * 48
 * 请从字符串中找出一个最长的不包含重复字符的子字符串，计算该最长子字符串的长度。



示例 1:

输入: "abcabcbb"
输出: 3
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。

 */


/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    if (s.length === 0) return 0
    if (s.length === 1) return 1

    //用来存放连续的不同的字符
    let chars = []
    //用来存放最大连续不同的字符串个数
    let res = 0

    for (let i = 0; i < s.length; i++) {
        //如果连续的不同的字符里面不包括当前元素
        if (!chars.includes(s[i])) {
            //将当前元素压入连续的不同的字符数组
            chars.push(s[i])
        } else { //如果当前元素在连续的不同的字符数组中已经出现过了
            //这一步是关键
            //将连续的不同的字符数组去掉从头到当前元素的部分
            chars = chars.slice(chars.indexOf(s[i]) + 1)
            //将当前元素再压入剩下的部分
            chars.push(s[i])
        }
        //每次比较一下连续的不同的字符数组长度是不是已知最大的，如果是的话就替换掉结果
        res = Math.max(chars.length, res)
    }

    return res
};
