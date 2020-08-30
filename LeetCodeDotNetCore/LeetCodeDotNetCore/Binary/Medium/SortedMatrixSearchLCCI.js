/**
 * 
给定M×N矩阵，每一行、每一列都按升序排列，请编写代码找出某元素。

示例:

现有矩阵 matrix 如下：

[
  [1,   4,  7, 11, 15],
  [2,   5,  8, 12, 19],
  [3,   6,  9, 16, 22],
  [10, 13, 14, 17, 24],
  [18, 21, 23, 26, 30]
]
给定 target = 5，返回 true。

给定 target = 20，返回 false。

 */

/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {boolean}
 */
var searchMatrix = function (matrix, target) {
    for (let i = 0; i < matrix.length; i++) {
        const row = matrix[i]
        if (row[0] > target || row[row.length - 1] < target) continue
        let l = 0, r = row.length - 1
        while (l <= r) {
            const mid = l + ((r - l) >>> 1)
            if (row[mid] === target) return true
            else if (row[mid] > target) r = mid - 1
            else l = mid + 1
        }
    }
    return false
};