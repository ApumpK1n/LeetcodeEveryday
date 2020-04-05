// 卡牌分组
// 最大公约数

using System.Collections.Generic;

public class Solution {
    public bool HasGroupsSizeX(int[] deck) {
        Dictionary<int> dec = new Dictionary<int>();
        foreach(int num in deck){
            if (dec.ContainsKey(num)) dec[num] += 1;
            else dec[num] = 1;
        }
        
    }
}