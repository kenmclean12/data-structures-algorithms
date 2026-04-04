public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        int leftProduct = 1;
        for (int i = 0; i < nums.Length; i++) {
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }

        int rightProduct = 1;
        for (int j = nums.Length - 1; j >= 0; j--) {
            result[j] *= rightProduct;
            rightProduct *= nums[j];
        }

        return result;
    }
}
