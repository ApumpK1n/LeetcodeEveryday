// 207. 课程表

/*
你这个学期必须选修 numCourse 门课程，记为 0 到 numCourse-1 。

在选修某些课程之前需要一些先修课程。 例如，想要学习课程 0 ，你需要先完成课程 1 ，我们用一个匹配来表示他们：[0,1]

给定课程总量以及它们的先决条件，请你判断是否可能完成所有课程的学习？
*/

// 拓扑排序，使用广度优先搜索。

// 只有入度为0时，表示课程可选。

public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] rudu = new int[numCourses]; //入度数
        Dictionary<int, List<int>> yilai = new Dictionary<int, List<int>>();//课程依赖关系
        for(int i=0; i<prerequisites.Length; i++){
            rudu[prerequisites[i][0]]++; // 后修的在前
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
        return ret.Count == numCourses;
    }
}