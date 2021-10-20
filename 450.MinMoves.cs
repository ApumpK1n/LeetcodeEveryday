// 453. 最小操作次数使数组元素相等

/*
因此，每次操作既可以理解为使 n-1个元素增加 1，也可以理解使 n-1 个元素减少 1。显然，后者更利于我们的计算。

于是，要计算让数组中所有元素相等的操作数，我们只需要计算将数组中所有元素都减少到数组中元素最小值所需的操作数.
*/

public class Solution {
    public int MinMoves(int[] nums) {
        int minNum = nums.Min();

        int result = 0;
        foreach(int num in nums)
        {
            result += num - minNum;
        }
        return result;
    }
}