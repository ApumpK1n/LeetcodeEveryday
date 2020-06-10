// 9. 回文数

using System.Collections;

// 先转成字符串比较
public class Solution {
    public bool IsPalindrome(int x) {
        string xstring = x.ToString();
        char[] reverse = xstring.ToCharArray();
        Array.Reverse(reverse);
        string reversestring = new string(reverse);
        for(int i=0; i<xstring.Length; i++){
            if (xstring[i] != reversestring[i]){
                return false;
            }
        }
        return true;
    }
}

// 进阶，不使用字符串，反转一半的整数，判断前后整数是否相等

public class Solution {
    public bool IsPalindrome(int x) {
        // 负数
        if (x < 0){
            return false;
        }
        // 除0之外的个位数为0的数
        if (x % 10 == 0 && x != 0){
            return false;
        }

        int reverse = 0;
        while(x > reverse){
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }
        // 长度为奇数时，奇数位于反转数个位, 去除
        return x == reverse || x == reverse / 10;
    }
}
