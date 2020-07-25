using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{

  public class KillProcess
    {
        /*
         * 给 n 个进程，每个进程都有一个独一无二的 PID （进程编号）和它的 PPID （父进程编号）。

            每一个进程只有一个父进程，但是每个进程可能会有一个或者多个孩子进程。它们形成的关系就像一个树状结构。只有一个进程的 PPID 是 0 ，意味着这个进程没有父进程。所有的 PID 都会是唯一的正整数。

            我们用两个序列来表示这些进程，第一个序列包含所有进程的 PID ，第二个序列包含所有进程对应的 PPID。

            现在给定这两个序列和一个 PID 表示你要杀死的进程，函数返回一个 PID 序列，表示因为杀这个进程而导致的所有被杀掉的进程的编号。

            当一个进程被杀掉的时候，它所有的孩子进程和后代进程都要被杀掉。

            你可以以任意顺序排列返回的 PID 序列。

            示例 1:

            输入: 
            pid =  [1, 3, 10, 5]
            ppid = [3, 0, 5, 3]
            kill = 5
            输出: [5,10]
            解释: 
                       3
                     /   \
                    1     5
                         /
                        10
            杀掉进程 5 ，同时它的后代进程 10 也被杀掉。

         */
        public IList<int> Solution(IList<int> pid, IList<int> ppid, int kill)
        {

            var queue = new Queue<int>();
            queue.Enqueue(kill);
            IList<int> result = new List<int>() { kill };
            var child = new Dictionary<int, IList<int>>();
            for (int i = 0; i < pid.Count; i++)             //将父进程作为字典key，子进程作为value的list
            {
                if (!child.ContainsKey(ppid[i]))
                {
                    child[ppid[i]] = new List<int>();
                    child[ppid[i]].Add(pid[i]);
                }
                else
                    child[ppid[i]].Add(pid[i]);
            }

            while (queue.Any())
            {
                int proc = queue.Dequeue();
                if (child.ContainsKey(proc))            //如果要kill的进程是作为父进程，有子进程，则遍历要kill的进程的子进程
                    foreach (var item in child[proc])
                    {
                        result.Add(item);
                        queue.Enqueue(item);            //把要kill的进程的子进程放到queue做下一次遍历
                    }


            }

            return result;


        }
    }
}
