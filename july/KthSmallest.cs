// 378. 有序矩阵中第K小的元素
// 给定一个 n x n 矩阵，其中每行和每列元素均按升序排序，找到矩阵中第 k 小的元素。
// 请注意，它是排序后的第 k 小元素，而不是第 k 个不同的元素。

using System.Collections.Generic;
public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        //int[] nums = new int[matrix.Length * matrix[0].Length];
        List<int> nums = new List<int>();
        for(int i=0; i<matrix.Length; i++)
        {
            for(int j=0; j<matrix[0].Length; j++){
                nums.Add(matrix[i][j]);
            }
        }
        nums.Sort();
        return nums[k-1];

        //int len = nums.Length;
       //for(int i=len / 2; i>=0; i--){
         //   BuildHeap(nums, i, len);
       // }

       // int size = len;
        //for(int i= len - 1; i>= nums.Length - k + 1; --i){
        //    change(nums, 0, i);
        //    --size;
        //    BuildHeap(nums, 0, size);
        //}
        //return nums[0];
    }

    private void BuildHeap(int[] nums, int i, int size){
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int min = i;
        if (left < size && nums[left] < nums[min]) min = left;
        if (right < size && nums[right] < nums[min]) min = right;
        if (min != i){
            change(nums, min, i);
            BuildHeap(nums, min, size);
        } 
    }

    private void change(int[] nums, int a, int b){
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}