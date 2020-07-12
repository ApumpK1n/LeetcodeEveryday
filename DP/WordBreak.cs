
// 139. 单词拆分

/*
给定一个非空字符串 s 和一个包含非空单词列表的字典 wordDict，判定 s 是否可以被空格拆分为一个或多个在字典中出现的单词。

说明：
拆分时可以重复使用字典中的单词。
你可以假设字典中没有重复的单词。
*/

// 设dp[i]为前i个字串是否可以被拆分

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        if (s.Length == 0) return false;
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true; //占一个格
        for(int i=1; i<= s.Length; i++){
            for(int j=0; j<i; j++){
                if (dp[j] && wordDict.Contains(s.Substring(j, i-j))){ //dp比索引大一位
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[s.Length];
    }
}