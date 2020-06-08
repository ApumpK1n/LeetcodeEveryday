// 128. 最长连续序列

// 给定一个未排序的整数数组，找出最长连续序列的长度。
//要求算法的时间复杂度为 O(n)。


public class Solution {
    public int LongestConsecutive(int[] nums) {
        var dic = new Dictionary<int, KeyValuePair<int, int>>();
        var maxLength = 0;//最大长度
        var head = 0;
        var tail = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                if (dic.ContainsKey(nums[i] - 1))//前一个数值存在于dic中
                {
                    head = dic[nums[i] - 1].Key;
                }
                else
                {
                    head = nums[i];
                }

                if (dic.ContainsKey(nums[i] + 1))//后一个数值存在于dic中
                {
                    tail = dic[nums[i] + 1].Value;
                }
                else
                {
                    tail = nums[i];
                }

                if (head != nums[i])//如果当前值不是所在区间的头
                {
                    dic[head] = new KeyValuePair<int, int>(head, tail);
                }

                if (tail != nums[i])//如果当前值不是所在区间的尾
                {
                    dic[tail] = new KeyValuePair<int, int>(head, tail);
                }

                if (tail - head + 1 > maxLength)
                {
                    maxLength = tail - head + 1;//更新最大长度
                }

                dic.Add(nums[i], new KeyValuePair<int, int>(head, tail));
            }
        }

        return maxLength;
    }
}