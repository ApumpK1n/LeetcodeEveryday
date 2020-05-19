// 680. 验证回文字符串 Ⅱ
// 给定一个非空字符串 s，最多删除一个字符。判断是否能成为回文字符串。

public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        int delNum = 0;
        return isPalindrome(s, left, right, delNum);
    }

    private bool isPalindrome(string s, int left, int right, int delNum){
        if (left >= right) return true;
        if (s[left] != s[right]){
            delNum += 1;
            if (delNum > 1){
                return false;
            }
            else{
                return isPalindrome(s, left + 1, right, delNum) || isPalindrome(s, left, right-1, delNum);
            }
        }
        return isPalindrome(s, left+1, right-1, delNum);
    }
}