
// 字符串转换整数 (atoi)
// 丢掉开头空格字符
// 后面多余字符忽略，不造成影响。

using System.Collections;


public class Solution {
    public int MyAtoi(string str) {
        string ret = "";
        ArrayList num = new ArrayList() {'0','1','2','3','4','5','6','7','8', '9'};
        ArrayList fuhao = new ArrayList() {'-', '+'};
        bool continueAdd = true;
        bool fuhao1 = false;
        bool zhen = true;
        foreach(char ch in str){
            if (ch == ' '){
                if (continueAdd) continue;
                else break;
            }
            else if (ch == '-' && !fuhao1){
                continueAdd = false;
                ret += ch;
                fuhao1 = true;
                zhen = false;
                }
            else if (ch == '+' && !fuhao1){
                continueAdd = false;
                ret += ch;
                fuhao1 = true;
                zhen = true;
                }
            else if (num.Contains(ch)){
                continueAdd = false;
                ret += ch;
                fuhao1 = true;
                }
            else break;
            
        }
        if (ret == "") return 0;
        if (ret.Length == 1 && fuhao.Contains(ret[0])) return 0;
        try{
            long intret = long.Parse(ret);
            if (intret > 0)
                intret = Math.Min(intret, 2147483647);
            if (intret < 0)            
                intret = Math.Max(intret, -2147483648);
            return (int)intret;
        }
        catch (OverflowException){
            return zhen? int.MaxValue : int.MinValue;
        }
        
        return 0;
    }
}