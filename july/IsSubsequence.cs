
// 392. 判断子序列

/*
给定字符串 s 和 t ，判断 s 是否为 t 的子序列。

你可以认为 s 和 t 中仅包含英文小写字母。字符串 t 可能会很长（长度 ~= 500,000），而 s 是个短字符串（长度 <=100）。

字符串的一个子序列是原始字符串删除一些（也可以不删除）字符而不改变剩余字符相对位置形成的新字符串。（例如，"ace"是"abcde"的一个子序列，而"aec"不是）。
*/

// 先暴力。
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int index = 0;
        int compare = 0;
        for(int i=0; i<s.Length; i++){
            int j = compare;
            while(j<t.Length){
                if (s[i] == t[j]){
                    index += 1;
                    compare = j + 1;
                    break;
                } 
                else{
                    compare++;
                    j++;
                } 
            }
        }
        return index == s.Length ? true : false;
    }
} 

// 双指针

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int m = 0;
        int n = 0;
        string res = "";
        while(m < s.Length && n < t.Length){
            if (s[m] == t[n]){
                res += s[m];
                m++;
                n++;
            }
            else{
                n++;
            }
        }
        return res == s ? true : false;
    }
}