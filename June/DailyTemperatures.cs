// 739. 每日温度

// 单调栈

using System.Collections.Generic;
public class Solution {
    public int[] DailyTemperatures(int[] T) {
        int length = T.Length;
        int[] ans = new int[length];
        Stack<int> stack = new Stack<int>();
        for (int i=0; i <length; i++){
            int temperature = T[i];
            while(stack.Count > 0 && temperature > T[stack.Peek()]){
                int preIndex = stack.Pop();
                ans[preIndex] = i - preIndex;
            }
            stack.Push(i);
        }
        return ans;
    }
}