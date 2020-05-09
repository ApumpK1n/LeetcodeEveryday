// 69. x 的平方根
/*
实现 int sqrt(int x) 函数。

计算并返回 x 的平方根，其中 x 是非负整数。

由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
*/


// 可以看做有序，二分查找

public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        int left = 1;
        int right = x;
        while(left + 1 < right){
            int mid = left + (right - left) / 2;
            if ((x / mid) >= mid){
                left = mid;
            }
            else{
                right = mid;
            }
        }
        return left;
    }
}