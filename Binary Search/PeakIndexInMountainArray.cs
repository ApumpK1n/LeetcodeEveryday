
// 852. 山脉数组的峰顶索引

/*
我们把符合下列属性的数组 A 称作山脉：

A.length >= 3
存在 0 < i < A.length - 1 使得A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
给定一个确定为山脉的数组，返回任何满足 A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1] 的 i 的值。

*/

// 找峰顶而已

public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int left = 0;
        int right = A.Length - 1;

        while(left <= right){
            int middle = left + (right - left) / 2;
            if (A[middle - 1] < A[middle] && A[middle + 1] < A[middle]){
                return middle;
            }
            else if (A[middle] < A[middle + 1]){
                left = middle + 1;
            }
            else if (A[middle] > A[middle + 1]){
                right = middle - 1;
            }
            else{
                left = middle + 1;
            }
        }
        return 0;
    }
}