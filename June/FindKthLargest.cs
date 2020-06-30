
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


// 构建最大堆

public class Solution {
    private int[] pq;
    public int FindKthLargest(int[] nums, int k) {
        BuildMaxHeap(nums);
        int size = nums.Length;
        for(int i= nums.Length - 1; i>= nums.Length - k + 1; --i){
            exch(0, i, nums);
            --size;
            Build(nums, 0, size);
        }
        return nums[0];
    }

    // 构建最大堆
    private void BuildMaxHeap(int[] nums)
    {
        for(int i= nums.Length / 2; i>=0; i--){
            Build(nums, i, nums.Length);
        }
    }

    private void Build(int[] nums, int root, int size){
        int left = root * 2 + 1;
        int right = root * 2 + 2;
        int largest = root;
        if (left < size && nums[left] > nums[largest]) largest = left;
        if (right < size && nums[right] > nums[largest] ) largest = right;
        if (root != largest){
            exch(root, largest, nums);
            Build(nums, largest, size);
        }
    }

    private void exch(int i, int j, int[] nums)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
} 