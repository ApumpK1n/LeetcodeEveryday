// 最长回文串
/* 回文字符串满足如果上一个是回文字串，那么下一个回文字串应该满足首尾字符相同,所以存在奇数字符为0或者为1
*/

using System.Collections.Generic;

public class Solution {
    public int LongestPalindrome(string s) {
        HashSet<char> st = new HashSet<char>();
        int Length = 0;
        foreach (char ch in s){
            if (st.Contains(ch)){
                Length += 2;
                st.Remove(ch);
            } // 偶数个直接加2
            else st.Add(ch); //奇数字符
        }
        //如果剩下奇数字符则长度+1
        if (st.Count > 0) Length += 1;
        return Length;
    }
}