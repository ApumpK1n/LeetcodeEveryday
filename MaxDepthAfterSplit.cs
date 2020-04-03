// 有效括号的嵌套深度 不相交子序列
// s = A + B
// if str == "" dp = 0;
// ( 表示压入一层栈 ) 表示出栈


using System.Collections.Generic;

public class Solution {
    public int[] MaxDepthAfterSplit(string seq) {
        List<int> ans = new List<int>();
        int d = 0;
        foreach (char c in seq){
            if (c == '('){  // 将一半元素丢入A
                d += 1;
                ans.Add(d % 2);
            }
            if (c == ')'){
                ans.Add(d % 2);
                d -= 1;
            }
        }
            
        return ans.ToArray();
    }
}