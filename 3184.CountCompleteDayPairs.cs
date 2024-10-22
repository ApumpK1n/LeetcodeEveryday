/*
3184. 构成整天的下标对数目 I

给你一个整数数组 hours，表示以 小时 为单位的时间，返回一个整数，表示满足 i < j 且 hours[i] + hours[j] 构成 整天 的下标对 i, j 的数目。

整天 定义为时间持续时间是 24 小时的 整数倍 。

例如，1 天是 24 小时，2 天是 48 小时，3 天是 72 小时，以此类推。
*/



// 1.两个for循环
public class Solution
{
    public int CountCompleteDayPairs(int[] hours)
    {
        int count = 0;
        for (int i = 0; i < hours.Length; i++) 
        {
            for (int j = i + 1; j < hours.Length; j++) 
            {
                int hour = hours[j] + hours[i];
                if (hour % 24 == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
