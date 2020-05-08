// 983. 最低票价

// 动态规划

// 比较一天前，7天前，30天前的花费，作为第i天的花费

using System;
using System.Collections.Generic;
public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        int lastday = days[days.Length-1];

        Dictionary<int, int> dp = new Dictionary<int, int>();
        dp[0] = 0;
        int idx = 0;

        for (int i = 1; i <= lastday; i++) {
            if (i == days[idx]) {
                int cost = int.MaxValue;
                int oneDayAgo = i-1;
                int sevenDaysAgo = i-7>0?i-7:0;
                int thirtyDaysAgo = i-30>0?i-30:0;

                cost = Math.Min(dp[oneDayAgo] + costs[0], cost);
                cost = Math.Min(dp[sevenDaysAgo] + costs[1], cost);
                cost = Math.Min(dp[thirtyDaysAgo] + costs[2], cost);

                dp[i] = cost;

                idx++;
            } else {
                dp[i] = dp[i-1];
            }
        }

        return dp[lastday];
    }
}