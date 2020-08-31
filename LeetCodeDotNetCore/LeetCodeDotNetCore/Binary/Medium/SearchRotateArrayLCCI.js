/*
 * 搜索旋转数组。给定一个排序后的数组，包含n个整数，但这个数组已被旋转过很多次了，次数不详。请编写代码找出数组中的某个元素，假设数组元素原先是按升序排列的。若有多个相同元素，返回索引值最小的一个。

示例1:

 输入: arr = [15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14], target = 5
 输出: 8（元素5在该数组中的索引）
示例2:

 输入：arr = [15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14], target = 11
 输出：-1 （没有找到）

 */


/**
 * @param {number[]} arr
 * @param {number} target
 * @return {number}
 */
var search = function (arr, target) {
    let left = 0, right = arr.length - 1
    if (right === -1) return -1
    while (left < right) { //此时结束条件是left = right
        const mid = left + ((right - left) >>> 1)
        if (arr[left] < arr[mid]) { //左区是递增的 
            if (target >= arr[left] && target <= arr[mid]) {//如果target在左区内
                right = mid
            } else { //target在右区
                left = mid + 1
            }
        } else if (arr[left] > arr[mid]) { //左区不是递增
            if (target >= arr[left] || target <= arr[mid]) { //如果target在左区
                right = mid
            } else {
                left = mid + 1
            }
        } else if (arr[left] === arr[mid]) { //如果左边界等于中位，此时可能找到target也可能是重复
            if (arr[left] !== target) { //重复的情况
                left++
            } else { //找到了target，并且left就是target的索引
                right = left //结束while循环
            }
        }
    }

    return arr[left] === target ? left : -1

};