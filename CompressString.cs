// 字符串压缩
public class Solution {
    public string CompressString(string S) {
        if (S.Length == 0) return S;
        string before = S[0].ToString();
        string result = "";
        for (int i= 1; i<S.Length; i++){
            string st = S[i].ToString();
            if (!before.Contains(st)){
                result += before[0]+before.Length.ToString();
                before = st;
            }
            else before += st;
        }
        if (before.Length > 0) result += before[0] + before.Length.ToString();
        if (result.Length >= S.Length) return S;
        return result;
    }
}