// 287. 寻找重复数

/*
给定一个包含 n + 1 个整数的数组 nums，其数字都在 1 到 n 之间（包括 1 和 n），可知至少存在一个重复的整数。假设只有一个重复的整数，找出这个重复的数。
*/

// 这题是二分法估算整数范围
// 1.O(1)的空间复杂度代表着不能用哈希表
// 2.数组不能改变代表着不能排序

public class Solution {
    public int FindDuplicate(int[] nums) {
        int left = 1;
        int right = nums.Length -1;
        while(left < right){
            int mid = left + (right - left) / 2;
            int cnt = 0;
            foreach(int num in nums){
                if(num <= mid){
                    cnt += 1; 
                }
            }

            if (cnt > mid){ // 正常来说，没有重复数的区间，小于等于估算数的总数应该和估算数一样，大于它即在区间内
                right = mid;
            }
            else{ // 反推，在另一个区间内
                left = mid + 1;
            }
        }
        return left;
    }
}