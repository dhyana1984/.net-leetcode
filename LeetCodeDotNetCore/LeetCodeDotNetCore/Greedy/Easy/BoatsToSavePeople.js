/**
    第 i 个人的体重为 people[i]，每艘船可以承载的最大重量为 limit。

    每艘船最多可同时载两人，但条件是这些人的重量之和最多为 limit。

    返回载到每一个人所需的最小船数。(保证每个人都能被船载)。



    示例 1：

    输入：people = [1,2], limit = 3
    输出：1
    解释：1 艘船载 (1, 2)
    示例 2：

    输入：people = [3,2,2,1], limit = 3
    输出：3
    解释：3 艘船分别载 (1, 2), (2) 和 (3)
    示例 3：

    输入：people = [3,5,3,4], limit = 5
    输出：4
    解释：4 艘船分别载 (3), (3), (4), (5)

 */

/**
 * @param {number[]} people
 * @param {number} limit
 * @return {number}
 */
var numRescueBoats = function(people, limit) {
    let n = people.length
    if(n===1) return 1
    let res = 0
    //先对人根据重量排序
    people.sort((a, b) => a - b)
    //如果还有人没走
    while (people.length) {
        //如果大于1个人
        if (people.length >= 2) {
            //如果最重的和最轻的重量小于limit，则这两个人从队列中删除，并且结果加1
            if(people[0]+people[n-1]<=limit){
                people.shift()
                people.pop()
                res++
            //否则将最重的人去除，结果+1
            }else{
                    people.pop()
                res++
            }
        //如果只剩最后一个人，那么结果+1即可
        }else{
                people.shift()
                res++
        }
        //队列长度刷新（去掉走掉的人）
        n = people.length
    }
    return res

};