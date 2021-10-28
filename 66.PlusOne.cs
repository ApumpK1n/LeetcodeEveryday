/*
给定一个由 整数 组成的 非空 数组所表示的非负整数，在该数的基础上加一。

最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。

你可以假设除了整数 0 之外，这个整数不会以零开头。

*/

using System.Collections.Generic;
public class Solution {
    public int[] PlusOne(int[] digits) {
        
        List<int> result = new List<int>();
        int num = 1;
        for(int i=digits.Length - 1; i >= 0; i--)
        {
            num = num + digits[i];
            if (num >= 10)
            {
                result.Insert(0, num % 10);
                num = num / 10;
            }
            else
            {
                result.Insert(0, num);
                num = 0; // 无进位
            }
        }
        if(num > 0) result.Insert(0, num);

        return result.ToArray();
    }
}