
// 剑指 Offer 38. 字符串的排列
/*
输入一个字符串，打印出该字符串中字符的所有排列。
你可以以任意顺序返回这个字符串数组，但里面不能有重复元素。
*/


using System.Collections.Generic;

public class Solution {
    public string[] Permutation(string s) {
        
        List<string> strs = new List<string>();
        char[] charArr = s.ToCharArray();
        // 排序是为了去重方便
        Array.Sort(charArr);

        bool[] visit = new bool[s.Length];

        dfs("", charArr, visit, strs);
        return strs.ToArray();
    }

    private void dfs(string nows, char[] charArr, bool[] visit, List<string> strs)
    {
        if (nows.Length == charArr.Length){
            strs.Add(nows);
            return;
        }
        for(int i=0; i<charArr.Length; i++){
            if (visit[i]) continue;
            if(i > 0 && !visit[i-1] && charArr[i-1] == charArr[i]) continue;

            visit[i] = true;

            string before = nows;
            nows += charArr[i];
            dfs(nows, charArr, visit, strs);

            // 回溯
            nows = before;
            visit[i] = false;
        }
    }
}