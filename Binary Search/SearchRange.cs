// 34. 在排序数组中查找元素的第一个和最后一个位置

/*
给定一个按照升序排列的整数数组 nums，和一个目标值 target。找出给定目标值在数组中的开始位置和结束位置。

你的算法时间复杂度必须是 O(log n) 级别。

如果数组中不存在目标值，返回 [-1, -1]。

*/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        if (n == 0) return new int[2]{-1, -1};
        int left = 0;
        int right = n - 1;
        
        while(left < right){
            int middle = left + (right - left) / 2;
            int compare = nums[middle];
            if (compare > target || compare == target){
                right = middle;
            }
            else{
                left = middle + 1;
            }
        }

        int startIndex = left;
        int[] res = new int[2];
        int len = 0;
        for(int i=startIndex; i<n; i++){
            if (nums[i] == target){
                len += 1;
            }
        }
        if (len > 0){
            res[0] = startIndex;
            res[1] = startIndex + len - 1;
        }

        return len > 0 ? res : new int[2]{-1, -1};
    }
}