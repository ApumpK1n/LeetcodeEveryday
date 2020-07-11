
// 315. 计算右侧小于当前元素的个数

/*
给定一个整数数组 nums，按要求返回一个新数组 counts。
数组 counts 有该性质： counts[i] 的值是  nums[i] 右侧小于 nums[i] 的元素的数量。
*/
// 先暴力, 果不其然超时了。
using System.Collections.Generic;
public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        List<int> res = new List<int>();
        for(int i=0; i< nums.Length; i++){
            int compare = nums[i];
            int num = 0;
            for(int j=i+1; j<nums.Length; j++){
                if (nums[j] < compare){
                    num ++;
                }
            }
            res.Add(num);
        }
        return res;
    }
}

// 优化寻找数字的时间复杂度
