// 45. 跳跃游戏 II

/*
给定一个非负整数数组，你最初位于数组的第一个位置。

数组中的每个元素代表你在该位置可以跳跃的最大长度。

你的目标是使用最少的跳跃次数到达数组的最后一个位置。
*/

// 贪心算法，求最大或者最小值时可以考虑

using System;

public class Solution {
    public int Jump(int[] nums) {
        int end = 0;
        int maxTo = 0;
        int step = 0;

        //维护当前位置可以到达的最大位置
        for(int i=0; i<nums.Length-1; i++) 
        {
            maxTo = Math.Max(maxTo, i + nums[i]);

            if (i == end) //走到结束位置时，更新。同时认为走了一步
            {
                end = maxTo;
                step++;
            } 
        }
        return step;
    }
}