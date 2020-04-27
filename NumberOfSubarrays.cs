// 统计「优美子数组」


// 双指针
public class Solution {
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int len = nums.Length;
        if (len < k) return 0;
        int left = 0, right = -1;
        int cnt = 0;
        int res = 0;
        while (right+1<len)
        {
            cnt += nums[++right] & 1;
            while (right+1<len && cnt<k ) cnt += nums[++right] & 1;
            if(right>=len) break;
            int k_right_begin = right;
            while (right + 1 < len && (nums[right+1] & 1) == 0) ++right;
            while (left<=right && cnt == k)
            {
                res += right - k_right_begin+1;
                cnt -= nums[left++] & 1;
            }
        }
        return res;
    }
}