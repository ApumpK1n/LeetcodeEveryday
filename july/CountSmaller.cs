
// 315. 计算右侧小于当前元素的个数

/*
给定一个整数数组 nums，按要求返回一个新数组 counts。
数组 counts 有该性质： counts[i] 的值是  nums[i] 右侧小于 nums[i] 的元素的数量。
*/
// 先暴力, 果不其然超时了。
using System.Collections.Generic;
public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        List<int> res = new List<int>();
        for(int i=0; i< nums.Length; i++){
            int compare = nums[i];
            int num = 0;
            for(int j=i+1; j<nums.Length; j++){
                if (nums[j] < compare){
                    num ++;
                }
            }
            res.Add(num);
        }
        return res;
    }
}

// 优化寻找数字的时间复杂度
public class Solution 
{
    private int[] c;

    private int[] a;

    private void Init(int length)
    {
        c = new int[length];
        Array.Fill(c, 0);
    }

    private int LowBit(int x)
    {
        return x & (-x);
    }

    private void Update(int pos)
    {
        while (pos < c.Length)
        {
            c[pos] += 1;
            pos += LowBit(pos);
        }
    }

    private int Query(int pos)
    {
        int ret = 0;
        while (pos > 0)
        {
            ret += c[pos];
            pos -= LowBit(pos);
        }

        return ret;
    }

    private void Discretization(int[] nums)
    {
        a = (int[])nums.Clone();
        var hashSet = new HashSet<int>(a);
        a = hashSet.ToArray();
        Array.Sort(a);
    }

    private int GetId(int x)
    {
        return Array.BinarySearch(a, x) + 1;
    }

    public IList<int> CountSmaller(int[] nums) 
    {
        var resultList = new List<int>(); 

        Discretization(nums);

        Init(nums.Length + 5);

        for (int i = nums.Length - 1; i >= 0; --i)
        {
            var id = GetId(nums[i]);
            resultList.Add(Query(id - 1));
            Update(id);
        }

        resultList.Reverse();

        return resultList;
    }
}