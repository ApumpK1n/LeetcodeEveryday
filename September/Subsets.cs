
// 78. 子集

/*
给定一组不含重复元素的整数数组 nums，返回该数组所有可能的子集（幂集）。

说明：解集不能包含重复的子集。
*/

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        if (nums == null || nums.Length <= 0) return result;

        Array.Sort(nums);
        
        BackTracking(nums, 0, new List<int>(), result);

        return result;
    }

    private void BackTracking(int[] nums, int pos, List<int> path, List<IList<int>> result){
        result.Add(new List<int>(path));

        for (int i = pos; i < nums.Length; ++i){
            path.Add(nums[i]);
            BackTracking(nums, i + 1, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}