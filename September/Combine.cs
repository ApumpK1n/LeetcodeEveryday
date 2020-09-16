

// 77. 组合

// 给定两个整数 n 和 k，返回 1 ... n 中所有可能的 k 个数的组合。

// 回溯
using System.Collections.Generic;
public class Solution {
    public IList<IList<int>> Combine(int n, int k) {

        List<IList<int>> res = new List<IList<int>>();
        List<int> num = new List<int>();
        combine(num, res, n, k);
        return res;
    }

    private void combine(List<int> num, List<IList<int>> res, int n, int k)
    {
        if (num.Count == k)
        {
            List<int> add = new List<int>(num);
            res.Add(add);
            return;
        }
        int last = 0;
        if (num.Count > 0){
            last = num[num.Count - 1];
        }
        for(int i = last + 1; i<=n; i++){
            num.Add(i);
            combine(num, res, n, k);
            num.RemoveAt(num.Count - 1);
        }
    }
}