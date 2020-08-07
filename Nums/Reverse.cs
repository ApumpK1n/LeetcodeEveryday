
// 7. 整数反转

/*
给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
*/
public class Solution {
   
    public int Reverse(int x)
    {
        long result = 0;

        while(x != 0){
            int temp = x % 10;
            result = result * 10 + temp;
            x /= 10;
        }

            //判断是否存在溢出，极易忽略这点
        if (result > int.MaxValue || result < int.MinValue)
        {
            result = 0;
        }

        return (int)result;
    }
}