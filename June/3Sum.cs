// 15. 三数之和
public class Solution {

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int len = nums.Length;
        if (len < 3) return result;
        Array.Sort(nums);
        for (int i = 0; i < len - 2; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue; // 去重
            int left = i + 1;
            int right = len - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) left++; // 去重
                    while (left < right && nums[right] == nums[right - 1]) right--; // 去重
                    left++;
                    right--;
                }
                else if (sum < 0) left++;
                else if (sum > 0) right--;
            }
        }
        return result;
    }
}