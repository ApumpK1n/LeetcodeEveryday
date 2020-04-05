// 圆圈中最后剩下的数字

using System.Collections.Generic;

public class Solution {
    public int LastRemaining(int n, int m) {
        ArrayList num = new ArrayList(n);
        for(int i=0; i<n; i++){
            num.Insert(i, i);
        }
        int temp = 0;
        while(n > 1){
            temp = (temp + m - 1) % num.Count;
            num.Remove(num[temp]);
            n--;
        }

        return (int)num[0];
    }
}

class Solution {
    public int lastRemaining(int n, int m) {
        int ans = 0;
        // 最后一轮剩下2个人，所以从2开始反推
        for (int i = 2; i <= n; i++) {
            ans = (ans + m) % i;
        }
        return ans;
    }
}


