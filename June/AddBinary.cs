// 67. 二进制求和

/*
给你两个二进制字符串，返回它们的和（用二进制表示）。

输入为 非空 字符串且只包含数字 1 和 0。
*/

public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        string ret = "";
        int jinwei = 0;
        while(i >= 0 && j >= 0){
            int num = int.Parse(a[i].ToString()) + int.Parse(b[j].ToString()) + jinwei;
            ret = (num % 2).ToString() + ret;
            jinwei = num / 2;
            i--;
            j--;
        }

        
        while(i >= 0){
            int num = int.Parse(a[i].ToString()) + jinwei;
            ret = (num % 2).ToString() + ret;
            jinwei = num / 2;
            i--;
        }

        while(j >= 0){
            int num = int.Parse(b[j].ToString()) + jinwei;
            ret = (num % 2).ToString() + ret;
            jinwei = num / 2;
            j--;
        }

        if (jinwei > 0){
            ret = jinwei.ToString() + ret;
        }

        return ret;
    }
}