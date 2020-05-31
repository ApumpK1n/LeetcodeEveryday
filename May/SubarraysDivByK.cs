
// 974. 和可被 K 整除的子数组
//给定一个整数数组 A，返回其中元素之和可被 K 整除的（连续、非空）子数组的数目。


// 前缀和
public class Solution {
    public int SubarraysDivByK(int[] A, int K) {
        int n = 0;
        int s = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        map.Add(0, 1);
        for(int i = 0; i < A.Length; i++)
        {
            s += A[i];
            s %= K;

            if(s < 0)
            {
                s += K;
            }

            int count = 0;
            if(map.TryGetValue(s, out count))
            {
                n += count;
                map[s] = count + 1;
            }
            else
            {
                map.Add(s, 1);
            }
        }
        
        return n;
    }
}