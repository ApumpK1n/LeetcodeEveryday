
// 350. 两个数组的交集 II

// 给定两个数组，编写一个函数来计算它们的交集。

using System;
//哈希表统计数量
using System.Collections.Generic;
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> res = new List<int>();
        Dictionary<int, int> dCount = new Dictionary<int, int>();
        for(int i=0; i<nums1.Length; i++){
            if (!dCount.ContainsKey(nums1[i])){
                dCount[nums1[i]] = 1;
            }
            else{
                dCount[nums1[i]] += 1;
            }
        }

        for(int j=0; j<nums2.Length; j++){
            int compare = nums2[j];
            if (dCount.ContainsKey(compare) && dCount[compare] > 0){
                res.Add(compare);
                dCount[compare] -= 1;
            }
        }
        return res.ToArray();
    }
}

// 双指针
// 先排序，初始指针指向头，比较两个值，不相等时谁小挪动谁的指针，相等时，记录数据并同时挪动指针。
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        List<int> res = new List<int>();
        int pNum1 = 0;
        int pNum2 = 0;
        while(pNum1 < nums1.Length && pNum2 < nums2.Length)
        {
            if (nums1[pNum1] > nums2[pNum2]){
                pNum2 += 1;
            }
            else if (nums1[pNum1] < nums2[pNum2]){
                pNum1 += 1;
            }
            else{
                res.Add(nums2[pNum2]);
                pNum1 += 1;
                pNum2 += 1;
            }
        }
        return res.ToArray();
    }
}