
// 32. 最长有效括号

// 给定一个只包含 '(' 和 ')' 的字符串，找出最长的包含有效括号的子串的长度。

//动态规划：
/*
设第i个位置时，有效括号的最大长度为dp[i]
则有：
1.s[i] == "("时 dp[i] = 0
2.s[i] == ")"时
1)"()()"这种形式的，如果s[i-1]为"(" 则 dp[i] = dp[i - 2] + 2
2)"(())"这种形式的，要找到左括号，左括号位置为 i-1-dp[i-1],如果括号为左括号则：dp[i] = dp[i-1] + 2.
3)"(())"这种形式的,可能前面会包含"()"这种形式，因此要加上，即：dp[i] = dp[i-1] + 2 + dp[i-1-dp[i-1] - 1]
*/

public class Solution {
    public int LongestValidParentheses(string s) {
        if (s.Length <=1) return 0;
        int[] dp = new int[s.Length];
        dp[0] = 0;
        if (s[0] == '(' && s[1] == ')'){
            dp[1] = 2;
        }
        else{
            dp[1] = 0;
        }
        int maxLen = dp[1];
        for(int i=2; i<s.Length; i++){
            if (s[i] == '(') dp[i] = 0;
            else{
                if (s[i-1] == '('){
                    dp[i] = dp[i - 2] + 2;
                }
                else{
                    int index = i - 1 - dp[i-1];
                    if (index >=0 && s[index] == '('){
                        int len = 0;
                        if (index - 1 >=0){
                            len =  dp[index - 1];
                        }
                        dp[i] = dp[i-1] + 2 + len;
                    }
                }
            }
            maxLen = Math.Max(maxLen, dp[i]);
        }
        return maxLen;
    }
}