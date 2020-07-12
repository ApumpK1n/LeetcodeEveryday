
// 309. 最佳买卖股票时机含冷冻期

/*

给定一个整数数组，其中第 i 个元素代表了第 i 天的股票价格 。​

设计一个算法计算出最大利润。在满足以下约束条件下，你可以尽可能地完成更多的交易（多次买卖一支股票）:

你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）。
卖出股票后，你无法在第二天买入股票 (即冷冻期为 1 天)
*/

// 设dp[i]为第i天时的最大利润
// dp[i]=0
// 1.今天卖 2.今天不卖 dp[]
public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        if( n == 0 )
            return 0;
        int[] hold = new int[n]; hold[0] = -prices[0];
        int[] free = new int[n];
        int[] cd = new int[n];
        for( int i = 1 ; i < n; i++ )
        {
            cd[i] = hold[i-1]+prices[i];
            hold[i] = Math.Max( hold[i-1], free[i-1]-prices[i]);
            free[i] = Math.Max( free[i-1], cd[i-1]);
        }
        return Math.Max(free[n-1], cd[n-1]);
    }
}