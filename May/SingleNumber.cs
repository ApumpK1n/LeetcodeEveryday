// 136. 只出现一次的数字

// 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

// 首先直接想到了哈希表，但是空间复杂度不满足常数空间。
// 看题解知异或
/*
交换律：a ^ b ^ c <=> a ^ c ^ b
任何数于0异或为任何数 0 ^ n => n
相同的数异或为0: n ^ n => 0
var a = [2,3,2,4,4]
2 ^ 3 ^ 2 ^ 4 ^ 4等价于 2 ^ 2 ^ 4 ^ 4 ^ 3 => 0 ^ 0 ^3 => 3

*/

public class Solution {
    public int SingleNumber(int[] nums) {
        int ret = 0;
        for(int i=0; i<nums.Length; i++){
            ret ^= nums[i];
        }
        return ret;
    }
}