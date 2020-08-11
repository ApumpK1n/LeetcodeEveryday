
// 696. 计数二进制子串

/*
给定一个字符串 s，计算具有相同数量0和1的非空(连续)子字符串的数量，并且这些子字符串中的所有0和所有1都是组合在一起的。

重复出现的子串要计算它们出现的次数。
*/

// 01 0011 000111 10 1100

//以上可以得出规律，连续相同最小数

using System.Collections.Generic;
public class Solution {
    public int CountBinarySubstrings(string s) {
        if (s.Length == 0) return 0;
        List<int> counts = new List<int>();
        int count = 1;
        for(int i=1; i<s.Length; i++){
            if (s[i-1] == s[i]){
                count ++;
            }
            else{
                counts.Add(count);
                count = 1;
            }
        }
        counts.Add(count);

        int res = 0;
        for(int i = 1; i < counts.Count; i++){
            res += Math.Min(counts[i-1], counts[i]); 
        }
        return res;
    }
}