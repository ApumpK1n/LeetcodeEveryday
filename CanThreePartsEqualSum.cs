public class Solution {
    public bool CanThreePartsEqualSum(int[] A) {
        int s = 0;
        for (int z=0;z<A.Length;z++){
            s += A[z];
        }
        if (s % 3 != 0) {
            return false;
        }
        int target = s / 3;
        int n = A.Length, i = 0, cur = 0;
        while (i < n) {
            cur += A[i];
            if (cur == target) {
                break;
            }
            i+=1;
        }
        if (cur != target) {
            return false;
        }
        int j = i + 1;
        while (j + 1 < n) {  // 需要满足最后一个数组非空
            cur += A[j];
            if (cur == target * 2) {
                return true;
            }
            j+=1;
        }
        return false;
    }
}