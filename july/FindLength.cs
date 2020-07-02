 // 718. 最长重复子数组

 // 给两个整数数组 A 和 B ，返回两个数组中公共的、长度最长的子数组的长度。
 // 暴力，超时了
public class Solution {
    public int FindLength(int[] A, int[] B) {
        int maxLen = 0;
        for(int i=0; i<A.Length; i++){
            int j=i;
            for(int x=0; x < B.Length; x++){
                if (A[j] == B[x]){
                    int aIndex = j;
                    int bindex = x;
                    while(aIndex < A.Length && bindex < B.Length)
                    {
                        if(A[aIndex] == B[bindex]){
                            aIndex ++;
                            bindex ++;
                        }
                        else{
                            break;
                        }
                    }
                    maxLen = Math.Max(maxLen, aIndex - i);
                }
            }
            
        }
        return maxLen;
    }
}

// 滑动窗口，每次将两个数组分别对齐
public class Solution {
    public int FindLength(int[] A, int[] B) {
        
        int ret = 0;
        for(int i=0; i<A.Length; i++){
            int len = Math.Min(B.Length, A.Length-i);
            int max = MaxLen(A, B, i, 0, len);
            ret = Math.Max(max, ret);
        }

        for(int i=0; i<B.Length; i++){
            int len = Math.Min(B.Length, B.Length-i);
            int max = MaxLen(A, B, 0, i, len);
            ret = Math.Max(max, ret);
        }
        return ret;
    }

    private int MaxLen(int[] A, int[] B, int indexa, int indexb, int len){
        int res = 0;
        int k=0;
        for(int i=0; i<len; i++){
            if(A[indexa + i] == B[indexb + i]){
                k++;
            }
            else{
                k = 0;
            }
            res = Math.Max(res, k);
        }
        return res;
    }
}