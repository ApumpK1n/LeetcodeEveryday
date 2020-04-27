// 数组中的逆序对

/*
初见懵逼，看题解用归并排序， 拆分成子问题
类似问题：315（和本题一样）,327,493
*/

public class Solution {
    public int ReversePairs(int[] nums) {
        int len = nums.Length;

        if (len < 2){
            return 0;
        }
        
        int[] copy = new int[len];
        for (int i = 0; i < len; i++){
            copy[i] = nums[i];
        }

        int[] temp = new int[len];
        return ReversePairs(copy, 0, len-1, temp);
    }

     /**
     * nums[left..right] 计算逆序对个数并且排序
     *
     * @param nums
     * @param left
     * @param right
     * @param temp
     * @return
     */
    public int ReversePairs(int[] nums, int left, int right, int[] temp){
        if (left == right) {
            return 0;
        }
        int mid = left + (right - left) / 2;
        int leftPairs = ReversePairs(nums, left, mid, temp);
        int rightPairs = ReversePairs(nums, mid + 1, right, temp);

        if (nums[mid] <= nums[mid + 1]) {// 有序
            return leftPairs + rightPairs;
        }

        int crossPairs = mergeAndCount(nums, left, mid, right, temp);
        return leftPairs + rightPairs + crossPairs;
    }

    /**
     * nums[left..mid] 有序，nums[mid + 1..right] 有序
     *
     * @param nums
     * @param left
     * @param mid
     * @param right
     * @param temp
     * @return
     */
    private int mergeAndCount(int[] nums, int left, int mid, int right, int[] temp) {
        for (int z = left; z <= right; z++) {
            temp[z] = nums[z];
        }

        int i = left;
        int j = mid + 1;

        int count = 0;
        for (int k = left; k <= right; k++) {

            if (i == mid + 1) {
                nums[k] = temp[j];
                j++;
            } else if (j == right + 1) {
                nums[k] = temp[i];
                i++;
            } else if (temp[i] <= temp[j]) {
                nums[k] = temp[i];
                i++;
            } else {
                nums[k] = temp[j];
                j++;
                count += (mid - i + 1);
            }
        }
        return count;
    }
} 
