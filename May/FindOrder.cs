// 210. 课程表 II

// 拓扑排序
// 把一个 有向无环图 变成 线性的排序 就叫 拓扑排序
// 使用广度优先遍历遍历有向无环图
/*
queue 队列中始终是【入度为 0 的课】在里面流动
选择一门课，就让它 出列，同时 查看哈希表，看它 对应哪些后续课
将这些后续课的 入度 - 1，如果有 减至 0 的，就将它 推入 queue
不再有新的入度 0 的课入列 时，此时 queue 为空，退出循环
*/
using System;
using System.Collections;
using System.Collections.Generic;
public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        int[] rudu = new int[numCourses]; //入度数
        Dictionary<int, List<int>> yilai = new Dictionary<int, List<int>>();//课程依赖关系
        for(int i=0; i<prerequisites.Length; i++){
            rudu[prerequisites[i][0]]++;
            if (yilai.ContainsKey(prerequisites[i][1])){
                yilai[prerequisites[i][1]].Add(prerequisites[i][0]);
            }
            else{
                List<int> lst = new List<int>(){prerequisites[i][0]};
                yilai[prerequisites[i][1]] = lst;
            }
        }
        List<int> ret = new List<int>(); //课程序列
        Queue<int> queue = new Queue<int>();
        // 把入度为0的课程添加到队列
        for(int i=0; i<numCourses; i++){
            if (rudu[i] == 0){
                queue.Enqueue(i);
            }
        }
        while(queue.Count > 0){
            int course = queue.Dequeue(); // 出队列，代表选择课程。
            ret.Add(course);
            if (yilai.ContainsKey(course)){
                List<int> yilaicourse = yilai[course];
                foreach(int co in yilaicourse){
                    rudu[co] --;
                    if (rudu[co] == 0){ // 入度为0，可以学习课程。
                        queue.Enqueue(co);
                    }
                }
            }
        }
        return (ret.Count == numCourses) ? ret.ToArray() : new int[]{};
    }
}