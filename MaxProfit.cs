// 买卖股票的最佳时机

// 1. 买卖操作一次 2.必须先买后卖 3.按时间顺序
// 第i天卖出时，找到包括自身的前几天的最小值
// 动态规划 第i天的最大利润为当天的卖出价格减最小买入价格与i-1天时的最大值
public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        for (int i=0; i<prices.Length; i++){
            minPrice = Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i]-minPrice);
        }
        return maxProfit;
    }
}