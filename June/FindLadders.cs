// 126. 单词接龙 II
/*
给定两个单词（beginWord 和 endWord）和一个字典 wordList，找出所有从 beginWord 到 endWord 的最短转换序列。转换需遵循如下规则：

每次转换只能改变一个字母。
转换过程中的中间单词必须是字典中的单词。
*/

// 广度优先搜索
//先构建图，然后搜索

using System.Collections.Generic;
public class Solution {
    private Dictionary<string, int> wordID = new Dictionary<string, int>(); // 单词到id映射
    private List<string> idWord = new List<string>(); //id到单词的映射
    private List<int[]> edges = new List<int[]>(); // 图的边
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        int id = 0;
        //将wordlist所有单词加入wordid中，并分配id
        foreach(string word in wordList){
            if (!wordID.ContainsKey(word)){
                wordID[word] = id++;
                idWord.Add(word);
            }
        }
        // 若endword 不在wordList中 则无解
        if( !wordID.ContainsKey(endWord)){
            return new List<string>();
        }
        // Add beginword
    }
}