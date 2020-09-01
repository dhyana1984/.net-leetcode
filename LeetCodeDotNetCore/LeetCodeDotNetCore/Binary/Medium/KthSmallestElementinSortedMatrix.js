﻿/*
 * 给定一个 n x n 矩阵，其中每行和每列元素均按升序排序，找到矩阵中第 k 小的元素。
请注意，它是排序后的第 k 小元素，而不是第 k 个不同的元素。



示例：

matrix = [
   [ 1,  5,  9],
   [10, 11, 13],
   [12, 13, 15]
],
k = 8,

返回 13。


提示：
你可以假设 k 的值永远是有效的，1 ≤ k ≤ n2 。
 */


/**
 * @param {number[][]} matrix
 * @param {number} k
 * @return {number}
 */
//非二分法解法
var kthSmallest = function (matrix, k) {
    return matrix.flat().sort((a, b) => a - b)[k - 1]
};

/**
 * @param {number[][]} matrix
 * @param {number} k
 * @return {number}
 */
function notGreaterCount(matrix, target) {
    // 等价于在matrix 中搜索mid，搜索的过程中利用有序的性质记录比mid小的元素个数

    // 我们选择左下角，作为开始元素
    let curRow = 0;
    // 多少列
    const COL_COUNT = matrix[0].length;
    // 最后一列的索引
    const LAST_COL = COL_COUNT - 1;
    let res = 0;

    while (curRow < matrix.length) {
        // 比较最后一列的数据和target的大小
        if (matrix[curRow][LAST_COL] < target) {
            res += COL_COUNT;
        } else {
            let i = COL_COUNT - 1;
            while (i < COL_COUNT && matrix[curRow][i] > target) {
                i--;
            }
            // 注意这里要加1
            res += i + 1;
        }
        curRow++;
    }

    return res;
}
/**
 * @param {number[][]} matrix
 * @param {number} k
 * @return {number}
 */
var kthSmallest = function (matrix, k) {
    if (matrix.length < 1) return null;
    let start = matrix[0][0];
    let end = matrix[matrix.length - 1][matrix[0].length - 1];
    while (start < end) {
        const mid = start + ((end - start) >> 1);
        const count = notGreaterCount(matrix, mid);
        if (count < k) start = mid + 1;
        else end = mid;
    }
    // 返回start,mid, end 都一样
    return start;
};