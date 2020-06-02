// 面试题64. 求1+2+…+n
// 求 1+2+...+n ，要求不能使用乘除法、for、while、if、else、switch、case等关键字及条件判断语句（A?B:C）。

// 语言特性，&&操作符前面语句为false时后一个语句将不会执行
public class Solution {
    public int SumNums(int n) {
        int res = n;
        bool flag = (n > 0) && (res += SumNums(n-1)) > 0;
        return res;
    }
}