/*
1390. 四因数
给你一个整数数组 nums，请你返回该数组中恰有四个因数的这些整数的各因数之和。如果数组中不存在满足题意的整数，则返回 0 。

示例 1：

输入：nums = [21,4,7]
输出：32
解释：
21 有 4 个因数：1, 3, 7, 21
4 有 3 个因数：1, 2, 4
7 有 2 个因数：1, 7
答案仅为 21 的所有因数的和。
*/
public class Solution {
    public int SumFourDivisors(int[] nums) {
        int result = 0;
        foreach(int num in nums){
            int factorNum = 0;
            int factorTotal = 0;
            //求因数 因数对法： 从一到数的平方根的数
            for(int i=1; i*i <= num; i++){
                if (num % i == 0) //x
                {
                    factorNum++;
                    factorTotal += i;
                    if(i * i != num) //y 并且相同的数不重复计入
                    {
                        factorNum++;
                        factorTotal += num / i;
                    }
                }
                
            }
            if (factorNum == 4){
                result += factorTotal;
            }
        }
        return result;
    }
}
