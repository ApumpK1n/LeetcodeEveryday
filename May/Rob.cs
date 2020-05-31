// 198. 打家劫舍

// 动态规划
// 两种情况：1.今天不偷 2.今天偷 最大值等于前天偷的+今天的钱 与昨天的偷的前比较
public class Solution {
    public int Rob(int[] nums) {
        int preMax = 0;
        int CurrMax = 0;
        foreach(int i in nums){
            int temp = CurrMax;
            CurrMax = Math.Max(preMax+i, CurrMax);
            preMax = temp;
        }
        return CurrMax;
    }
}