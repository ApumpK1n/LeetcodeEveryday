//卡牌分组


using System.Collections.Generic;

public class Solution {
    public bool HasGroupsSizeX(int[] deck) {
        Dictionary<int, int> dec = new Dictionary<int, int>();
        foreach(int num in deck){
            if (dec.ContainsKey(num)) dec[num] += 1;
            else dec[num] = 1;
        }
        int[] arr = dec.Values.ToArray();
        for(int i = 1; i < arr.Length; i++){
            if(gcd(arr[i-1], arr[i]) == 1){
                return false;
            }
        }

        return arr[0] > 1 ? true : false;
    }

    public int gcd(int a, int b){ //辗转相除法
        if(a < b){
            int temp = b;
            b = a;
            a = temp;
        }

        if(a % b != 0){
            return gcd(a % b, b);
        }

        return b;
    }
}