// 翻转字符串里的单词
// 给定一个字符串，逐个翻转字符串中的每个单词。


public class Solution {
    public string ReverseWords(string s) {
        string[] arr = s.Split(' ');
        string res = "";
        foreach (string ar in arr){
            if (ar == "") continue;
            string st = ar;
            if (res != "") st += " ";
            res = st + res;
        }
        return res;
    }
}