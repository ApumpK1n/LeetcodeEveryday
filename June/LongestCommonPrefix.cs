// 14. 最长公共前缀
/*
编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。
*/

//暴力解法
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        string res = "";
        for(int j=0; j < strs[0].Length; j++){
            for(int i = 1; i < strs.Length; i++)
            {
                if (j >= strs[i].Length || strs[0][j] != strs[i][j]){
                    return res;
                }
            }
            res += strs[0][j];
        }
        return res;
    }
}
