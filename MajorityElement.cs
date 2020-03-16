/*
多数元素
给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。

你可以假设数组是非空的，并且给定的数组总是存在多数元素。
*/

// 第一次想到哈希表

using System.Collections.Generic;

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> Num = new Dictionary<int, int>{};
        foreach (int num in nums){
            if (!Num.ContainsKey(num)){
                Num.Add(num, 1);
            }
            else{
                Num[num] += 1;
            }
        }
        int result = 0;
        foreach(int num in Num.Keys){
            if (Num[num] > (nums.Length / 2)){
                result = num;
                break;
            }
        }
        return result;
    }
}