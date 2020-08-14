// 20. 有效的括号

/*
给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

有效字符串需满足：

左括号必须用相同类型的右括号闭合。
左括号必须以正确的顺序闭合。
注意空字符串可被认为是有效字符串。
*/

public class Solution {
    public bool IsValid(string s) {
        if(s == null) return false;
        if(s == string.Empty) return true;
        Dictionary<char, char> mapping = new Dictionary<char, char>{
            {'(', ')'}, {'{', '}'}, {'[', ']'}
        };
        Stack<char> stack = new Stack<char>();
        foreach(char str in s){
            if(mapping.ContainsKey(str)) stack.Push(mapping[str]);
            else
            {
                char compare = '&';
                if (stack.Count>0) compare = stack.Pop();
                if (compare != str) return false;
            }
        };
        return stack.Count == 0;   
    }
}