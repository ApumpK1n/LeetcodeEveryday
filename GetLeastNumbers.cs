// 最小的K个数
//O(n*k)
public class Solution {
    public int[] GetLeastNumbers(int[] arr, int k) {
        int [] ret = new int[k];
        if (k == 0) return ret;
        int MaxIndex = 0;
        for (int i=0; i<arr.Length; i++){
            if (i<k) {
                ret[i] = arr[i];
                if (ret[i] > ret[MaxIndex]) MaxIndex = i;
            }
            else {
                if (arr[i] < ret[MaxIndex]){;
                    ret[MaxIndex] = arr[i];
                    for (int j=0; j<k; j++){
                        if (ret[j] > ret[MaxIndex]) MaxIndex = j;
                    }
                }
                }
        }
        return ret;
    }
}