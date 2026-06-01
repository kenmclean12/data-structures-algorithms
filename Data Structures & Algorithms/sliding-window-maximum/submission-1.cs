public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] result = new int[nums.Length - k + 1];

        for (int i = 0; i < result.Length; i++) {
            int maxVal = int.MinValue;
            for (int j = i; j < i + k; j++) {
                maxVal = Math.Max(maxVal, nums[j]);
            }
            
            result[i] = maxVal;
        }

        return result;
    }
}
