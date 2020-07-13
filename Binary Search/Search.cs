// 704. 二分查找

//最基本的二分查找
public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;

        if (n == 0) return -1;
        int left = 0;
        int right = n - 1;
        while(left <= right){
            int middel = left + (right - left) / 2;
            if (nums[middel] > target){
                right = middel - 1;
            }
            else if (nums[middel] < target){
                left = middel + 1;
            }
            else{
                return middel;
            }
        }
        return -1;
    }
}