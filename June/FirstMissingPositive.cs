// 41. 缺失的第一个正数

// 给你一个未排序的整数数组，请你找出其中没有出现的最小的正整数。

// 数组看做哈希表,下标用作索引key
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int len = nums.Length;
        for(int i=0; i<len; i++){
            while(nums[i] > 0 && nums[i] <= len && nums[nums[i] - 1] != nums[i]){
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }
        }
        for(int i = 0; i < len; i++){
            if(nums[i] != i + 1){
                return i + 1;
            }
        }
        return len + 1;
    }
}