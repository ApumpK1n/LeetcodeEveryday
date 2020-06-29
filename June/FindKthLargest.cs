
// 215. 数组中的第K个最大元素
// 在未排序的数组中找到第 k 个最大的元素。请注意，你需要找的是数组排序后的第 k 个最大的元素，而不是第 k 个不同的元素。


// 快速排序
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        QuickSort(nums, 0, nums.Length - 1);
        return nums[nums.Length - k];
    }

    private void QuickSort(int[] arr, int left, int right){
        if (left >= right) return;
        int compare = arr[left];
        int low = left;
        int high = right;
        while(left < right){
            while(left < right && arr[right] >= compare){
                right --;
            }
            arr[left] = arr[right];
            while(left < right && arr[left] <= compare){
                left ++;
            }
            arr[right] = arr[left];
        }
        arr[left] = compare;

        QuickSort(arr, left + 1, high);
        QuickSort(arr, low, left - 1);
    }
}