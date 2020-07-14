

// 347. 前 K 个高频元素
/*
给定一个非空的整数数组，返回其中出现频率前 k 高的元素。
*/

// 哈希表法

using System.Collections.Generic;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> hashtable = new Dictionary<int, int>();
        List<int> lstNum = new List<int>();
        List<int> lstKey = new List<int>();
        for(int i=0; i<nums.Length; i++){
            if (hashtable.ContainsKey(nums[i])){
                hashtable[nums[i]] += 1;
            }
            else{
                hashtable[nums[i]] = 1;
            }
        }
        
        foreach(KeyValuePair<int, int> keyValue in hashtable){
            lstNum.Add(keyValue.Value);
            lstKey.Add(keyValue.Key);
        }
        List<int> res = new List<int>();
        for(int i=0; i<k; i++){
            int num = lstNum.Max();
            int index = lstNum.IndexOf(num);
            res.Add(lstKey[index]);
            lstNum.RemoveAt(index);
            lstKey.RemoveAt(index);
        }
        return res.ToArray();
    }
}