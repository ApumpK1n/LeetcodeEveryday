

// 875. 爱吃香蕉的珂珂

/*
珂珂喜欢吃香蕉。这里有 N 堆香蕉，第 i 堆中有 piles[i] 根香蕉。警卫已经离开了，将在 H 小时后回来。

珂珂可以决定她吃香蕉的速度 K （单位：根/小时）。每个小时，她将会选择一堆香蕉，从中吃掉 K 根。如果这堆香蕉少于 K 根，她将吃掉这堆的所有香蕉，然后这一小时内不会再吃更多的香蕉。  

珂珂喜欢慢慢吃，但仍然想在警卫回来前吃掉所有的香蕉。

返回她可以在 H 小时内吃掉所有香蕉的最小速度 K（K 为整数）。
*/

// 根据题意，实际上就是求每小时吃多少根香蕉可以刚好满足H小时的最小值。
//所以取初始值为两端的香蕉数量作为初始速度，然后每次算当前吃香蕉的时间与总时间做对比

using System;
public class Solution {
    public int MinEatingSpeed(int[] piles, int H) {
        Array.Sort(piles);
        int n = piles.Length;
        int left = 1;
        int right = piles[n-1];
        while(left < right){
            int speed = left + (right - left) / 2;
            int time = 0;
            for(int i=0; i<n; i++){
                time += piles[i] / speed;
                if (piles[i] % speed > 0){
                    time += 1;
                }
            }
            if (time > H){
                left = speed + 1;
            }
            else 
            {
                right = speed;
            }
        }
        return left;
    }
}