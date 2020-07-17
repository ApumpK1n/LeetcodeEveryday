
//搜索插入位置
//实际上就是相同元素不插入，其他元素按照顺序排列。

// 35. 搜索插入位置

/*
给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。

你可以假设数组中无重复元素。
*/
// 二分
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int n = nums.Length;
        if (n == 0) return 0;
        // 特判
        if (nums[n - 1] < target) {
            return n;
        }

        int left = 0;
        int right = nums.Length - 1;
        while(left < right){
            int mid = left + (right - left) / 2;
            if (nums[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid;
            }
        }
        return left;
    }
}