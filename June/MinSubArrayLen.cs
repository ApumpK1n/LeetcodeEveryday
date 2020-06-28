
// 209. 长度最小的子数组

// 给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的连续子数组，并返回其长度。如果不存在符合条件的连续子数组，返回 0。

// 子串问题用双指针滑动窗口

public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int start = 0;
        int end = 0;
        int num = 0;
        int minLen = int.MaxValue;
        while(end < nums.Length){
            num += nums[end];
            while (num >= s){
                minLen = Math.Min(minLen, end - start + 1);
                num -= nums[start];
                start ++;
            }
            end ++;
        }
        return minLen == int.MaxValue ? 0 : minLen;
    }
}