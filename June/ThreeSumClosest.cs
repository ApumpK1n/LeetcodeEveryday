
// 16. 最接近的三数之和

// 给定一个包括 n 个整数的数组 nums 和 一个目标值 target。找出 nums 中的三个整数，使得它们的和与 target 最接近。返回这三个数的和。假定每组输入只存在唯一答案。

using System.Collections;

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int ans = nums[0] + nums[1] + nums[2];
        for(int i= 0; i<nums.Length; i++){
            int start = i + 1;
            int end = nums.Length - 1;
            while(start < end){
                int sum = nums[start] + nums[end] + nums[i];
                if (Math.Abs(target - sum) < Math.Abs(target - ans)){
                    ans = sum;
                }
                if (sum > target){
                    end -- ;
                }
                else if (sum < target){
                    start ++;
                }
                else{
                    return ans;
                }
            }
        }
        return ans;
    }
}