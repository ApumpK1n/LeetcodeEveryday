

// 415. 字符串相加

/*
给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。

注意：

num1 和num2 的长度都小于 5100.
num1 和num2 都只包含数字 0-9.
num1 和num2 都不包含任何前导零。
你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式。
*/

using System.Collections.Generic;

public class Solution {
    public string AddStrings(string num1, string num2) {
        int m = num1.Length - 1;
        int n = num2.Length - 1;
        int add = 0;
        string res = "";
        while(m >= 0 || n >= 0 || add != 0){
            int a = m >= 0 ? num1[m] - '0' : 0;
            int b = n >= 0 ? num2[n] - '0' : 0;
            int num = a + b + add;

            add = num / 10;
            num %= 10;
            res = num.ToString() + res;
            m --;
            n --;
        }
        return res;
    }
}