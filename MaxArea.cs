// 盛最多水的容器
// 双指针，面积有最小长度决定

using System;

public class Solution {
    public int MaxArea(int[] height) {
        int m = 0;
        int n = height.Length - 1;
        int Area = 0;
        while(m != n){
            int he = Math.Min(height[n], height[m]);
            Area = Math.Max(Area, he * (n - m));
            if (height[n] < height[m]){
                n -= 1;
            }
            else{
                m += 1;
            }
        }
        return Area;
    }
}