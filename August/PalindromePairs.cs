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


public class Solution {
        List<String> wordsRev = new List<String>();
        Dictionary<String, int> indices = new Dictionary<String, int>();

        public IList<IList<int>> PalindromePairs(string[] words) {
            int n = words.Length;
            for (int i = 0; i < n; i++) {
                Char[] str = words[i].ToCharArray();
                Array.Reverse(str);
                wordsRev.Add(new string(str));
            }
            for (int i = 0; i < n; ++i) {
                indices.Add(wordsRev[i], i);
            }

            IList<IList<int>> ret = new List<IList<int>>();
            for (int i = 0; i < n; i++) {
                string word = words[i];
                int m = words[i].Length;
                if (m == 0) {
                    continue;
                }
                for (int j = 0; j <= m; j++) {
                    if (isPalindrome(word, j, m - 1)) {
                        int leftId = findWord(word, 0, j - 1);
                        if (leftId != -1 && leftId != i) {
                            IList<int> temlst = new List<int>();
                            temlst.Add(i);
                            temlst.Add(leftId);
                            ret.Add(temlst);
                        }
                    }
                    if (j != 0 && isPalindrome(word, 0, j - 1)) {
                           int rightId = findWord(word, j, m - j - 1);
                        if (rightId != -1 && rightId != i) {
                            IList<int> temlst = new List<int>();
                            temlst.Add(rightId);
                            temlst.Add(i);
                            ret.Add(temlst);
                        }
                    }
                }
            }
            return ret;
        }

        public bool isPalindrome(string s, int left, int right) {
            int len = right - left + 1;
            for (int i = 0; i < len / 2; i++) {
                if (s[left + i] != s[right - i]) {
                    return false;
                }
            }
            return true;
        }

        public int findWord(string s, int left, int right) {
            string str = s.Substring(left, right + 1);
            if(!indices.ContainsKey(str))
                return -1;
            else 
                return indices[str];
        }
}