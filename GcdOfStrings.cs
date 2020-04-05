//字符串的最大公因子
//能除尽代表有共同重复字符串，而且为整数倍
public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        string str1com = "";
        foreach(char st in str1){
            if (!str1com.Contains(st)) str1com += st;
        }
        string compare1 = str1com;
        bool b1 = false;
        while(compare1.Length <= str1.Length){
            if (compare1 == str1) {
                b1 = true;
                break;
            }
            else compare1 += str1com;
        }

        string str2com = "";
        foreach(char st in str2){
            if (!str2com.Contains(st)) str2com += st;
        }
        string compare2 = str2com;
        bool b2 = false;
        while(compare2.Length <= str2.Length){
            if (compare2 == str2) {
                b2 = true;
                break;
            }
            else compare2 += str2com;
        }
        string result = "";
        string Max = "";
        if (b1 == true && b2 == true){
            foreach(char st1 in str1com){
                foreach(char st2 in str2com){
                    if (st1 == st2) {
                        result += st1;
                        break;
                    }
                    else{
                        if (result.Length > Max.Length) {
                            Max = result;
                            };
                    }
                }
            }
            if (result.Length > Max.Length) {
                Max = result;
                };
        }
        return Max;
    }
}