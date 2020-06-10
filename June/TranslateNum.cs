
// 面试题46. 把数字翻译成字符串


// 动态规划
public class Solution{
    public int TranslateNum(int num)
    {
        string s = string.Format($"{num}");
        if (s.Length == 1) return 1;
        int p2 = (int.Parse(s.Substring(0, 2)) < 26) && (int.Parse(s.Substring(0, 2)) > 9) ? 1 : 0;
        int p1 = 1;
        int p = 0;
        if(s.Length == 2)return p2+p1;
        for (int i = 1; i < s.Length; i++)
        {
            p = p1 + ((int.Parse(s.Substring(i - 1, 2)) < 26) && (int.Parse(s.Substring(i - 1, 2)) > 9) ? p2 : 0);
            p2 = p1;
            p1 = p;
        }
        return p;
    }
}
