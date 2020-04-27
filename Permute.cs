// 全排列
// 给定一个 没有重复 数字的序列，返回其所有可能的全排列。
// 像这种要求排列组合，一般都是用回溯法来做，回溯法就是深度优先遍历的树形表现形式。



using System.Collections.Generic;
using System.Collections;

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        int len = nums.Length;
        if (len == 0) return null;
        IList<IList<int>> result = new List<IList<int>>();
        List<int> nowNum = new List<int>();
        bool[] used = new bool[len];

        void Dfs(int depth, List<int> nowNum, bool[] used){
            if (depth == nums.Length) {
                result.Add(new List<int>(nowNum)); // 保留地址，新建List
                return;
            }
            for (int i = 0; i < nums.Length; i++){
                if (used[i]){
                    continue;
                }
                used[i] = true;
                nowNum.Add(nums[i]);
                Dfs(depth+1, nowNum, used);
                // 引用传递，需要回溯。
                nowNum.Remove(nums[i]);
                used[i] = false;
            }
        }

        Dfs(0, nowNum, used);
        return result;
    }


}