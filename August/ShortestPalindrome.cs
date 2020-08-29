public class Solution {
    public string ShortestPalindrome(string s) 
    {

        //利用双指针 找到第一个字符开始的最大长度的回文串
        int left = 0;
        int right = s.Length - 1;
        //记录一下最大回文串的长度
        int index = right;
        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                left = 0;
                index = index -1;
                right = index;
            }
        }
        string ans = "";
        //倒着把剩下的字母加入原来的字符串
        for (int i = s.Length - 1; i > index; i--)
        {
            ans += s[i];
        }
        return ans+s;
    }
}