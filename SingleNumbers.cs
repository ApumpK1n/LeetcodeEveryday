// 面试题56 - I. 数组中数字出现的次数
// 一个整型数组 nums 里除两个数字之外，其他数字都出现了两次。请写程序找出这两个只出现一次的数字。要求时间复杂度是O(n)，空间复杂度是O(1)。
// 如果a、b两个值不相同，则异或结果为1。如果a、b两个值相同，异或结果为0
// 全员异或的值为ret, 有ret = a^b, 只需在ret的二进制中找到一个为1的位p, a,b在p位不同（a!=b则ab至少有一位不同，则一定存在p位）
// 再次遍历，按照p位分成两组。可以证明：1.相同的数字一定在一组 2.a和b在不同分组
//1 ^ 1 = 0, 0 ^ 1 = 1, 0 ^ 0 = 1
// x & -x 从右到左第一位出现的1


public class Solution {
    public int[] SingleNumbers(int[] nums) {
        int xorSum = 0;
        int[] ret = new int[2]{0, 0};
        foreach(int i in nums){
            xorSum ^= i;
        }
        int lowbit = xorSum & (-xorSum);
        foreach (int x in nums){
            ret[(x & lowbit) > 0 ? 0 : 1] ^= x;
        }
        return ret;
    }
}