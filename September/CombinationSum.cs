
// 39. 组合总和

/*
给定一个无重复元素的数组 candidates 和一个目标数 target ，找出 candidates 中所有可以使数字和为 target 的组合。

candidates 中的数字可以无限制重复被选取。

说明：

所有数字（包括 target）都是正整数。
解集不能包含重复的组合。 
*/
public class Solution {
    private IList<IList<int>> res;
    private int[] candidates;
    private int target;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        this.res = new List<IList<int>>();
        Array.Sort(candidates);
        this.candidates = candidates;
        this.target = target;
        int sum = 0;
        var list = new Stack<int>();
        backTracking(0, sum, list);
        return res;
    }
    private void backTracking(int lastPos, int sum, Stack<int> list){  //lastPos是为了避免重复
        if(sum == target){
            res.Add(new List<int>(list));
            return;
        }
        for(int i = lastPos; i < candidates.Length; ++i){
            if(sum + candidates[i] > target) continue; //提前判断少一层递归
            sum += candidates[i];
            list.Push(candidates[i]);
            backTracking(i, sum, list);
            sum -= candidates[i];
            list.Pop();
        }
    }
}