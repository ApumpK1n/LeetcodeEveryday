/*
给定一个非负整数数组，你最初位于数组的第一个位置。

数组中的每个元素代表你在该位置可以跳跃的最大长度。

判断你是否能够到达最后一个位置。*/

// 贪心算法 
// 维护一个可到达的最大距离,如果当前位置在可到达距离内，遍历数组更新最大距离，判断最大距离是否大于等于最后位置

using System;
public class Solution {
    public bool CanJump(int[] nums) {
        int maxLength = 0;
        int m = nums.Length;
        for (int i=0; i<m; i++){
            if(i <= maxLength){
                maxLength = Math.Max(maxLength, i + nums[i]);
                if (maxLength >= m - 1) return true;
            } // 在可到达的位置范围内
        }
        return false;
    }
}