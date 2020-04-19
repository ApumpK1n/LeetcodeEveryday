/* 统计重复个数
由 n 个连接的字符串 s 组成字符串 S，记作 S = [s,n]。例如，["abc",3]=“abcabcabc”。
定义一个[S2, M] = X, X = S2*M X包含于S1,
已知s1, n1 s2, n2
可得S1 = s1*n1 S2 = s2*n2
X = S2*M 包含于 S1 

找出循环节即子串
 */


using System.Collections.Generic;

public class Solution {
    public int GetMaxRepetitions(string s1, int n1, string s2, int n2) {
        if (n1 == 0) return 0;
        int s1Cnt = 0;
        int index = 0;
        int s2Cnt = 0;
        Dictionary<int, List<int>> reCall = new Dictionary<int, List<int>>();
        List<int> preLoop = new List<int>();
        List<int> inLoop = new List<int>();
        while(true){
            // 多遍历s1找循环节
            s1Cnt += 1;
            foreach(char ch in s1){
                if (ch == s2[index]){
                    index += 1;
                    if (index == s2.Length){
                        s2Cnt += 1;
                        index = 0;
                    }
                }
            }
            // 没有循环节
            if (s1Cnt == n1){
                return s2Cnt / n2;
            }
            // 出现之前index,有循环节
            if (reCall.ContainsKey(index)){
                List<int> lst = reCall[index];
                int s1CntPre = lst[0];
                int s2CntPre = lst[1];
                preLoop = lst;
                inLoop.Add(s1Cnt - s1CntPre);
                inLoop.Add(s2Cnt - s2CntPre);
                break;

            }
            else{
                reCall.Add(index, new List<int>(){s1Cnt, s2Cnt});
            }
        }

        int ans = preLoop[1] + (n1 - preLoop[0]) / inLoop[0] * inLoop[1];

        int rest = (n1 - preLoop[0]) % inLoop[0];
        for(int i=0; i<rest; i++){
            foreach(char ch in s1){
                if (ch == s2[index]){
                    index += 1;
                    if (index == s2.Length){
                        ans += 1;
                        index = 0;
                    }
                }
            }
        }

        // S1包含 ans 个 s2, 那么就包含 ans/n2 个S2
        return ans / n2;
    }
}