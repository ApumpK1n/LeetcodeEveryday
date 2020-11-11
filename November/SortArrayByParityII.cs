/*
922. 按奇偶排序数组 II
给定一个非负整数数组 A， A 中一半整数是奇数，一半整数是偶数。

对数组进行排序，以便当 A[i] 为奇数时，i 也是奇数；当 A[i] 为偶数时， i 也是偶数。

你可以返回任何满足上述条件的数组作为答案。

*/

public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        int i = 0;
        int j = 1;
        while (i < A.Length && j < A.Length)
        {
            if(A[i] % 2 != 0&& A[j] % 2 == 0)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
            if (A[i] % 2 == 0) i += 2;
            if (A[j] % 2 != 0) j += 2;
        }
        return A;
        
    }
}