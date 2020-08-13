// 43. 字符串相乘

/*
给定两个以字符串形式表示的非负整数 num1 和 num2，返回 num1 和 num2 的乘积，它们的乘积也表示为字符串形式。
*/

public class Solution {
    public string Multiply(string num1, string num2) {

        int index1 = num1.Length - 1;
        int index2 = num2.Length - 1;
        int[] rst = new int[num1.Length + num2.Length];
        for(int i = index1; i >= 0; i--)
        {
            for(int j = index2; j>=0; j--){
                int n1 = num1[index1] - '0';
                int n2 = num2[index2] - '0';

                int num = n1 * n2 + rst[i + j + 1];
                rst[i + j] += num / 10;
                rst[i + j + 1] = num % 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        int k = 0;
        // 去掉前导0
        while(k < rst.Length-1 && rst[k] == 0) 
            k++;
        for(; k < rst.Length; ++k)
            sb.Append(rst[k]);
        return sb.ToString();
    }
}