// 50. Pow(x, n)

//实现 pow(x, n) ，即计算 x 的 n 次幂函数。
// 暴力法超時
// 使用递归
public class Solution {
    public double MyPow(double x, int n) {
        long N = n;
        return N >= 0? quickMul(x, N) : 1.0 / quickMul(x, -N);
    }

    private double quickMul(double x, long n){
        if (n == 0){
            return 1.0;
        }
        double y = quickMul(x, n/2);
        return n % 2 == 0 ? y*y : y*y*x;
    }
}