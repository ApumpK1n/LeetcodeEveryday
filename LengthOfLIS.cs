// 最长上升子序列
// 给定一个无序的整数数组，找到其中最长上升子序列的长度。
public class Solution {
    public int LengthOfLIS(int[] nums) {
        int result = 0;
        for(int i=0; i<nums.Length; i++){
            int max = 1;
            int current = nums[i];
            for(int j=i+1;j<nums.Length; j++){
                if (nums[j]>current) {
                    current = nums[j];
                    max += 1;
                }
            }
            result = Math.Max(max, result);
        }
        return result;
    }
}