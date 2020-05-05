
// 3. 无重复字符的最长子串
// 给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

using System;
using System.Collections.Generic;


// 暴力解法
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == ""){
            return 0;
        }
        if (s.Length == 1){
            return 1;
        }
        int n = s.Length;
        int maxLen = 0;
        for (int i=0; i<n; i++){
            string res = "";
            res += s[i];
            for(int j=i+1; j<n; j++){
                if (res.Contains(s[j])){
                    maxLen = Math.Max(maxLen, res.Length);
                    res = "";
                    break;
                }
                else{
                    res += s[j];
                }
            }
            if (res.Length > 0){
                maxLen = Math.Max(maxLen, res.Length);
            }
        }
        return maxLen;
    }
}



// 滑动窗口
// 双指针维持不重复队列
public class Solution {
    
    public int LengthOfLongestSubstring(string s) {

        List<char> ls = new List<char>();

        int n = s.Length;

        int intMaxLength = 0;

        for (int i = 0; i < n; i++)
        {
            if (ls.Contains(s[i])) // 出现重复字符，题义表明子串为连续的
            {
                ls.RemoveRange(0, ls.IndexOf(s[i]) + 1); // 维持的子由0->重复位置的最大子串长度一定小于从0开始的。
            }

            ls.Add(s[i]);
            
            intMaxLength = ls.Count > intMaxLength ? ls.Count : intMaxLength;
        }

        return intMaxLength;
    }
}