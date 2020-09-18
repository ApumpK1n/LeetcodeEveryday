
// 47. 全排列 II
// 给定一个可包含重复数字的序列，返回所有不重复的全排列。

// 回溯
using System.Collections.Generic;
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        List<IList<int>> res = new List<IList<int>>(); 

        List<int> now = new List<int>();
        bool[] vis = new bool[nums.Length];
        Array.Sort(nums);
        permuteUnique(res, nums, now, vis);
        return res;
    }
    

    private void permuteUnique(IList<IList<int>> res, int[] nums, List<int> now, bool[] vis)
    {
        if (now.Count == nums.Length){
            res.Add(new List<int>(now));
            return;
        }

        for(int i=0; i<nums.Length; i++){
            if (vis[i]) continue;

            if (i > 0 && nums[i] == nums[i - 1] && !vis[i - 1]) {
                continue;
            }

            now.Add(nums[i]);
            vis[i] = true;
            permuteUnique(res, nums, now, vis);
            vis[i] = false;
            now.RemoveAt(now.Count - 1);
        }
    }
}