

// 17. 电话号码的字母组合

/*
给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。
给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。
*/

using System.Collections.Generic;
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<string> combinations = new List<string>();
        if(digits.Length == 0){
            return combinations;
        } 
        Dictionary<char, string> phoneMap = new Dictionary<char, string>(){
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };

        dfs(combinations, phoneMap, digits, 0, "");
        return combinations;
    }

    private void dfs(List<string> combinations, Dictionary<char, string> phoneMap, string digits, int index, string combination){
        if (index == digits.Length){
            combinations.Add(combination);
        }
        else{
            char digit = digits[index];
            string letters = phoneMap[digit];
            int lettersCount = letters.Length;
            for(int i=0; i<lettersCount; i++){
                
                combination = combination + letters[i].ToString();
                dfs(combinations, phoneMap, digits, index + 1, combination);
                combination = combination.Remove(combination.Length - 1); 
            }
        }
    }
}