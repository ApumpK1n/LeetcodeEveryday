// 递归
// 括号问题每次添加括号都可以看做两种情况 1.左括号有剩余可以添加左括号 2.先添加了左括号才可添加右括号
// 在这里括号初始值都为n，所以剩余数量 1.左>0：可以添加左 2.右>左：可以添加右


using System.Collections.Generic;
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> ret = new List<string>();
        void generateParenthesis(int left, int right, string curstr){
            if (left == 0 && right == 0 ){
                ret.Add(curstr);
                return;
            }
            if (left > 0) generateParenthesis(left-1, right, curstr+"(");
            if (right > left) generateParenthesis(left, right-1, curstr+")");

        }
        generateParenthesis(n, n, "");
        return ret;
    }
}