// 1095.山脉数组中查找目标值

/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

// 先单调递增后单调递减，有序或者部分有序用二分查找

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int left = 0;
        int right = mountainArr.Length() - 1;
        // 先找到峰顶
        while(left < right){
            int mid = left + (right - left) / 2;
            if (mountainArr.Get(mid) <= mountainArr.Get(mid + 1)){
                left = mid + 1;
            }
            else{
                right = mid;
            }
        }
        // 根据题意，峰顶一定存在故不用判断。
        int top = left;

        int index = findInMountainArrayleft(0, top, target, mountainArr);
        if (index == -1){
            index = findInMountainArrayright(top, mountainArr.Length() - 1, target, mountainArr);
        }
        return index;
    }

    private int findInMountainArrayleft(int left, int right, int target, MountainArray mountainArr)
    {
        while(left < right){
            int mid = left + (right - left) / 2;
            int midNum = mountainArr.Get(mid);
            if (midNum < target){
                left = mid + 1;
            }
            else if (midNum > target){
                right = mid;
            }
            else if (midNum == target){
                return mid;
            }
        }

        // 区间缩小为一个元素时单独判断
        if (mountainArr.Get(left) == target) {
            return left;
        }
        return -1;
    }

    private int findInMountainArrayright(int left, int right, int target, MountainArray mountainArr)
    {
        while(left < right){
            int mid = left + (right - left) / 2;
            int midNum = mountainArr.Get(mid);
            if (midNum > target){
                left = mid + 1;
            }
            else if (midNum < target){
                right = mid;
            }
            else if (midNum == target){
                return mid;
            }
        }

        // 区间缩小为一个元素时单独判断
        if (mountainArr.Get(left) == target) {
            return left;
        }
        return -1;
    }
}