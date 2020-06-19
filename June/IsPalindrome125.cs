// 125. 验证回文串

/*
给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
说明：本题中，我们将空字符串定义为有效的回文串。
*/
// 双指针
public class Solution {
    public bool IsPalindrome(string s) {
        string filter = string.Empty;
        foreach(char st in s){
            if (char.IsLetterOrDigit(st)){
                filter += char.ToLower(st);
            }
        }
        int left = 0, right = filter.Length - 1;
        while(left < right){
            if (filter[left] != filter[right]){
                return false;
            }
            left ++;
            right --;
        }
        return true;
    }
}