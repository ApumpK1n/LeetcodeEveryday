// 202.快乐数
/*
编写一个算法来判断一个数 n 是不是快乐数。

「快乐数」定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，然后重复这个过程直到这个数变为 1，也可能是 无限循环 但始终变不到 1。如果 可以变为  1，那么这个数就是快乐数。

如果 n 是快乐数就返回 True ；不是，则返回 False 。
*/

// 使用快慢指针找环

public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = Square(n);
        while(fast != 1 && slow != fast)
        {    
            slow = Square(slow);
            fast = Square(fast);
            fast = Square(fast);
        }
        return (fast == 1);
    }

    private int Square(int num){
        int sum = 0;
        while(num > 0){
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}