

// 174. 地下城游戏

/*
一些恶魔抓住了公主（P）并将她关在了地下城的右下角。地下城是由 M x N 个房间组成的二维网格。我们英勇的骑士（K）最初被安置在左上角的房间里，他必须穿过地下城并通过对抗恶魔来拯救公主。

骑士的初始健康点数为一个正整数。如果他的健康点数在某一时刻降至 0 或以下，他会立即死亡。

有些房间由恶魔守卫，因此骑士在进入这些房间时会失去健康点数（若房间里的值为负整数，则表示骑士将损失健康点数）；其他房间要么是空的（房间里的值为 0），要么包含增加骑士健康点数的魔法球（若房间里的值为正整数，则表示骑士将增加健康点数）。

为了尽快到达公主，骑士决定每次只向右或向下移动一步。

 
编写一个函数来计算确保骑士能够拯救到公主所需的最低初始健康点数。


*/

// 因每次走只有两种方式，所以是二维dp问题，如果每次都可以走任意方向则是深度优先遍历问题
// 这里设dp[i][j] 为i行j列时当前所需骑士的最小生命值。如果是正推dp的话，后面的路径会影响到前面的路径选择。
//故逆推dp, 要求最低初始健康点数，只需到达公主时，生命点数为1.
// 即初始值dp[i][j] = 1
// 则上一个值为 dp[i][j] = dp[i][j+1] - nums[i,j]

public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int row = dungeon.Length;
        if (row == 0) return 1;
        int col = dungeon[0].Length;
        
        int[,] dp = new int[row, col];
        for(int i = row - 1; i>=0; i--){
            for(int j = col - 1; j >= 0; j--){
                if (i == row-1 && j == col - 1)// 终点
                {
                    dp[i, j] = Math.Max(1, 1 - dungeon[i][j]); // 所需生命值不能低于1
                }
                else if (i == row - 1 && j != col - 1) // 最后一行
                {
                    dp[i, j] = Math.Max(1, dp[i, j+1] - dungeon[i][j]);
                }
                else if (i != row - 1 && j == col - 1) // 最后一列
                {
                    dp[i, j] = Math.Max(1, dp[i+1, j] - dungeon[i][j]);
                }
                else
                {
                    dp[i, j] = Math.Max(1, Math.Min(dp[i+1,j], dp[i, j+1]) - dungeon[i][j]); // 选出两条路径中所需最小值
                }
            }
        }
        return dp[0, 0];
    }
}