// 5. 最长回文子串

// 回文子串问题都可用动态规划解决
// 设dp[i][j]是否为回文子串，true表为。 i为起始位置，j为结束位置。

public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length < 2) return s;
        bool [,] dp = new bool[s.Length,s.Length];
        // 先设置每个单独的元素为回文子串
        for(int i=0; i<s.Length; i++){
            dp[i,i] = true;
        }
        int maxLen = 1;
        int start = 0;
        // 从第二个元素开始
        for(int k=1; k<s.Length; k++){
            for(int j=0; j<k; j++){
                if (s[j] == s[k]){
                    if (k-j < 3){ // 3个字符以内出现相等情况都为回文子串
                        dp[j, k] = true;
                    }
                    else{ // 上一个子串为回文串则为回文串
                        dp[j, k] = dp[j+1, k-1];
                    }
                }
                else{
                    dp[j,k] = false;
                }
                // 如果回文子串长度有更长的，则更新。
                if (dp[j, k] == true && k-j + 1 > maxLen){
                    maxLen = k-j + 1;
                    start = j;
                }
            }
        }
        string result = "";
        for (int k = start; k<s.Length; k++){
            if (k>= start + maxLen) break;
            result += s[k];
        }
        return result;
    }
}