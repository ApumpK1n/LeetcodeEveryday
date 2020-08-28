

// 459. 重复的子字符串

/*
给定一个非空的字符串，判断它是否可以由它的一个子串重复多次构成。给定的字符串只含有小写英文字母，并且长度不超过10000。
*/

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length;
        for(int i=1; i * 2 <= n; i++){
            if (n % i == 0){
                bool match = true;
                for(int j = i; j<n; j++){
                    if (s[j] != s[j-i]){
                        match = false;
                        break;
                    }
                }
                if (match) return true;
            }
        }
        return false;
    }
}