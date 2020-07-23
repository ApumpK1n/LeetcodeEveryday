
// 263. 丑数
/*
编写一个程序判断给定的数是否为丑数。

丑数就是只包含质因数 2, 3, 5 的正整数。
*/

public class Solution {
    public bool IsUgly(int num) {
        if (num == 0){
            return false; 
        }   
        if (num == 1) return true;
        if (num % 2 == 0){
            return IsUgly(num / 2);
        }
        else if (num % 3 == 0){
            return IsUgly(num / 3);
        }
        else if (num % 5 == 0){
            return IsUgly(num / 5);
        }
        return false;
    }
}