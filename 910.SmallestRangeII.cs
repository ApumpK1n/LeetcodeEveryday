public class Solution
{
    public int SmallestRangeII(int[] nums, int k)
    {

        int n = nums.Length; // 获取数组的大小
        Array.Sort(nums); // 将数组按升序排序
        int ans = nums[n - 1] - nums[0]; // 初始的最大值差，未做任何调整时的最大减最小

        // 遍历数组，从第二个元素开始到最后一个元素
        for (int i = 1; i < n; i++)
        {
            // 在每次迭代中，计算调整后区间的最大和最小值
            // max(nums[n - 1] - k, nums[i - 1] + k): 调整后的最大值，要么是原数组最大值减去k，要么是当前遍历到的前一个元素加上k
            // min(nums[0] + k, nums[i] - k): 调整后的最小值，要么是原数组最小值加上k，要么是当前遍历到的元素减去k
            // ans: 取每次计算结果中的最小值
            ans = Math.Min(ans, Math.Max(nums[n - 1] - k, nums[i - 1] + k) - Math.Min(nums[0] + k, nums[i] - k));
        }

        return ans; // 返回最小的区间差值
    }
}