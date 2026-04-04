public class Solution {
    public int MaxProduct(int[] nums) {
        int currentMin = nums[0];
        int currentMax = nums[0];
        int maxProduct = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            int num = nums[i];
            int tempMin = Math.Min(num, Math.Min(num * currentMin, num * currentMax));
            int tempMax = Math.Max(num, Math.Max(num * currentMin, num * currentMax));

            currentMin = tempMin;
            currentMax = tempMax;

            maxProduct = Math.Max(maxProduct, currentMax);
        }

        return maxProduct;
    }
}
