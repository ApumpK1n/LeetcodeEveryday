
// 491. 递增子序列

/*
给定一个整型数组, 你的任务是找到所有该数组的递增子序列，递增子序列的长度至少是2。
*/


public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var current = new List<int>();
        var result = new List<IList<int>>();
        Backtrack(0, nums, current, result);
        return result;
    }

    public void Backtrack(int startIndex, int[] nums, List<int> current, List<IList<int>> result)
    {
        if (current.Count >= 2)
            result.Add(new List<int>(current));
        if (startIndex == nums.Length) return;

        var set = new HashSet<int>();
        for (int index = startIndex; index < nums.Length; index++)
        {
            if (set.Contains(nums[index])) continue;
            if (current.Count > 0 && current.Last() > nums[index]) continue;

            set.Add(nums[index]);
            current.Add(nums[index]);
            Backtrack(index + 1, nums, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}