
// 557. 反转字符串中的单词 III

/*
给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。
*/

public class Solution {
    public string ReverseWords(string s) {
        var res = new StringBuilder();
        foreach(var i in s.Split(" ")){
            var tmp = i.ToCharArray();
            Array.Reverse(tmp);
            res.Append(new String(tmp)+" ");
        }
        var r = res.ToString();
        return r.Substring(0,r.Length-1);
    }
}
