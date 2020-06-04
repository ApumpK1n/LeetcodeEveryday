// 238. 除自身以外数组的乘积

// 给你一个长度为 n 的整数数组 nums，其中 n > 1，返回输出数组 output ，其中 output[i] 等于 nums 中除 nums[i] 之外其余各元素的乘积。

// 1.暴力解法,超时了。                                                                                                                                                                                                                                                  
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ret = new int[nums.Length];
        for(int i=0; i<nums.Length; i++){
            int num = 1;
            for(int j=0; j<nums.Length; j++){
                if (j==i) continue;
                num *= nums[j];
            }
            ret[i] = num;
        }
        return ret;
    }
}