
// 679. 24 点游戏

// 你有 4 张写有 1 到 9 数字的牌。你需要判断是否能通过 *，/，+，-，(，) 的运算得到 24。

public class Solution {
    public bool JudgePoint24(int[] nums) {
        List<double> list = new List<double>();
        foreach(int i in nums) list.Add((double)i); //为dfs做准备
        return dfs(list);
    }
    private bool dfs(List<double> list){
        if(list.Count == 1){
            if(Math.Abs(list[0] - 24.0) < 0.001) return true; //考虑除法造成的小数点
            return false;
        }
        for(int i = 0; i < list.Count; ++i){
            for(int j = i + 1; j < list.Count; ++j){
                foreach(double c in generatePossibleResults(list[i], list[j])){
                    List<double> nextRound = new List<double>();
                    nextRound.Add(c); //遍历两个数的所有可能性
                    for(int k = 0; k < list.Count; ++k){ //添加剩余项到next round
                        if(k == i || k == j) continue;
                        nextRound.Add(list[k]);
                    }
                    if(dfs(nextRound)) return true; 
                }
            }
        }
        return false;
    }
    //生成两个数所有的组合
    private List<double> generatePossibleResults(double a, double b){
        List<double> res = new List<double>();
        res.Add(a + b);
        res.Add(a - b);
        res.Add(b - a);
        res.Add(a * b);
        res.Add(a / b);
        res.Add(b / a);
        return res;
    }
}