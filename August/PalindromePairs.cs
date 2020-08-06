// 336. 回文对

/*
给定一组唯一的单词， 找出所有不同 的索引对(i, j)，使得列表中的两个单词， words[i] + words[j] ，可拼接成回文串。
*/

// 先暴力, 超出时间限制了。
using System.Collections.Generic;
public class Solution {
    public IList<IList<int>> PalindromePairs(string[] words) {
        
        IList<IList<int>> res = new List<IList<int>>();
        for(int i=0; i<words.Length; i++){
            for(int j=0; j<words.Length; j++){
                
                if (i == j) continue;
                string filter = words[i] + words[j];
                int left = 0;
                int right = filter.Length - 1;
                bool k = true;
                while(left < right){
                    if (filter[left] != filter[right]){
                        k = false;
                        break;
                    }
                    left ++;
                    right --;
                }
                if (k){
                    res.Add(new List<int>(){i, j});
                }
            }
        }
        return res;
    }
}