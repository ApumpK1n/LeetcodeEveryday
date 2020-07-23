
// 581. 最短无序连续子数组
// 给定一个整数数组，你需要寻找一个连续的子数组，如果对这个子数组进行升序排序，那么整个数组都会变为升序排序。

// 你找到的子数组应是最短的，请输出它的长度。

// 从左到右找到第一个递减的数，为右边界
// 从右到左找到第一个递增的数，为左边界。

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int len = nums.Length;
        if (len <=1) return 0;
        int high = 0;
        int low = len - 1;
        int curMax = int.MinValue;
        int curMin = int.MaxValue;
        for(int i=0; i<nums.Length; i++){
            if (nums[i] >= curMax){
                curMax = nums[i];
            }
            else{
                high = i;
            }
            if (nums[len - 1 - i] <= curMin){
                curMin = nums[len-1-i];
            }
            else{
                low = len - 1 - i;
            }
        }
        return high > low ? high - low + 1 : 0;
    }
}