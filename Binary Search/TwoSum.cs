
// 167. 两数之和 II - 输入有序数组

/*
给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。

函数应该返回这两个下标值 index1 和 index2，其中 index1 必须小于 index2。

说明:

返回的下标值（index1 和 index2）不是从零开始的。
你可以假设每个输入只对应唯一的答案，而且你不可以重复使用相同的元素。
*/

// 双指针
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int left = 0;
        int right = n - 1;

        while(left <= right)
        {
            int compare = numbers[left] + numbers[right];
            if (compare == target){
                return new int[2]{left + 1, right + 1};
            }
            else if (compare > target){
                right -= 1;
            }
            else{
                left += 1;
            }
        }
        return new int[1];
    }
}