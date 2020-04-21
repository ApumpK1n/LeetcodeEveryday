// 统计「优美子数组」


// 暴力解法
public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int ret = 0;
        for(int i=0; i<nums.Length; i++){
            int count = 0;
            for(int j=i; j<nums.Length; j++){
                if (nums[j] % 2 != 0) count += 1;
                if (count >= k){
                    ret += 1;
                    break;
                }
            }
        }
        return ret;
    }
}