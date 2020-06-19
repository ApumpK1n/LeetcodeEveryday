
// 1014. 最佳观光组合

// 公式拆分为 (A[i]+ i) + (A[j] - j)
// 动态规划，维护前面i最大值就行。
public class Solution {
    public int MaxScoreSightseeingPair(int[] A) {
        if (A.Length == 0) return 0;
        int MaxNum = 0;
        int preMax = A[0] + 0; // 前最大值
        for(int i = 1; i < A.Length; i++){
            MaxNum = Math.Max(MaxNum, preMax + A[i] - i);
            preMax = Math.Max(preMax, A[i] + i);
        }
        return MaxNum;
    }
}