// 632. 最小区间
/*
你有 k 个升序排列的整数数组。找到一个最小区间，使得 k 个列表中的每个列表至少有一个数包含在其中。

我们定义如果 b-a < d-c 或者在 b-a == d-c 时 a < c，则区间 [a,b] 比 [c,d] 小。
*/


// 哈希表+滑动窗口 CV的

using System.Collections.Generic;
public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
        int size = nums.Count;
        Dictionary<int, List<int>> indices = new Dictionary<int, List<int>>();
        int xMin = int.MaxValue;
        int xMax = int.MinValue;
        for (int i=0; i<size; i++){
            foreach(int x in nums[i]){
                List<int> lst = new List<int>();
                if (indices.ContainsKey(x)){
                    lst = indices[x];
                    lst.Add(i);
                }
                else{
                    lst.Add(i);
                    indices[x] = lst;
                }
                
                xMin = Math.Min(xMin, x);
                xMax = Math.Max(xMax, x);
            }
        }

        int[] freq = new int[size];
        int inside = 0;
        int left = xMin;
        int right = xMin - 1;
        int bestLeft = xMin;
        int bestRight = xMax;

        while(right < xMax){
            right ++;
            if (indices.ContainsKey(right)){
                foreach(int x in indices[right]){
                    freq[x] ++;
                    if (freq[x] == 1){
                        inside ++;
                    }
                }
                while(inside == size){
                    if (right - left < bestRight - bestLeft){
                        bestLeft = left;
                        bestRight = right;
                    }
                    if (indices.ContainsKey(left)){
                        foreach(int x in indices[left]){
                            freq[x] --;
                            if (freq[x] == 0){
                                inside --;
                            }
                        }
                    }
                    left ++;
                }
            }
        }
        return new int[]{bestLeft, bestRight};
    }
}