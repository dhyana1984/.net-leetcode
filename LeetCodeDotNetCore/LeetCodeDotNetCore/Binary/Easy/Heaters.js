/*
 * 冬季已经来临。 你的任务是设计一个有固定加热半径的供暖器向所有房屋供暖。

现在，给出位于一条水平线上的房屋和供暖器的位置，找到可以覆盖所有房屋的最小加热半径。

所以，你的输入将会是房屋和供暖器的位置。你将输出供暖器的最小加热半径。

说明:

给出的房屋和供暖器的数目是非负数且不会超过 25000。
给出的房屋和供暖器的位置均是非负数且不会超过10^9。
只要房屋位于供暖器的半径内(包括在边缘上)，它就可以得到供暖。
所有供暖器都遵循你的半径标准，加热的半径也一样。
示例 1:

输入: [1,2,3],[2]
输出: 1
解释: 仅在位置2上有一个供暖器。如果我们将加热半径设为1，那么所有房屋就都能得到供暖。
示例 2:

输入: [1,2,3,4],[1,4]
输出: 1
解释: 在位置1, 4上有两个供暖器。我们需要将加热半径设为1，这样所有房屋就都能得到供暖。

 */

/**
 * @param {number[]} houses
 * @param {number[]} heaters
 * @return {number}
 */
var findRadius = function (houses, heaters) {
    houses.sort((a, b) => a - b)
    heaters.sort((a, b) => a - b)
    // 左边加入最小值，为了少判断一个j === 0的情况
    heaters.unshift(Number.MIN_SAFE_INTEGER)
    // 右边加入最大值，为了少判断j === heaters.length的情况
    heaters.push(Number.MAX_SAFE_INTEGER)
    let res = 0, j = 1 // 供暖器index
    const n = heaters.length
    for (let i = 0; i < houses.length; i++) {

        // 遍历找到第一个比房子大的供暖器，即找到离房子最近的右边的供暖器，则j - 1是离房子最近的右边的供暖器
        // 因为多push了一个最大值，因此不需要判断j是否已经超过越界
        while (j < n - 1 && houses[i] > heaters[j]) {
            j++
        }
        // 房子距离两边供暖器的最小距离
        const dist = Math.min(houses[i] - heaters[j - 1], heaters[j] - houses[i])
        res = Math.max(res, dist)
    }
    return res

};