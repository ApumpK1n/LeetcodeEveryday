
// 面试题 16.11. 跳水板

/*
你正在使用一堆木板建造跳水板。有两种类型的木板，其中长度较短的木板长度为shorter，长度较长的木板长度为longer。你必须正好使用k块木板。编写一个方法，生成跳水板所有可能的长度。

返回的长度需要从小到大排列。
*/

using System.Collections.Generic;

// 递归超时了。。。。。
public class Solution {
    public int[] DivingBoard(int shorter, int longer, int k) {
        HashSet<int> res = new HashSet<int>();
        if (k == 0) return res.ToArray();
        divingBoard(res, shorter, longer, k, 0);
        //res.Sort();
        return res.ToArray();
    }

    private void divingBoard(HashSet<int> res, int shorter, int longer, int k, int num)
    {
        if (k == 0){
            res.Add(num);
            return;
        }
        divingBoard(res, shorter, longer, k-1, num + shorter);
        divingBoard(res, shorter, longer, k-1, num + longer);

    }
}

//用数学方法解吧
public class Solution {
    public int[] DivingBoard(int shorter, int longer, int k) {
        if (k == 0) return new int[0];
        if (shorter == longer){
            
            return new int[] {shorter * k};
        }
        int[] res = new int[k + 1];
        int Num = shorter * k; // 最小值
        res[0] = Num;
        for(int i=0; i<k; i++){ // 每次替换一块木板长度，因为长度不重复。
            Num = Num + longer - shorter;
            res[i+1]  =Num;
        }
        return res;
    }
}