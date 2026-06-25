public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
      int[] result = new int[nums.Length - k + 1];

      for (int i = 0; i < result.Length; i++) {
        int maxValue = int.MinValue;
        for (int j = i; j < i + k; j++) {
          if (nums[j] > maxValue) {
            maxValue = nums[j];
          }
        }

        result[i] = maxValue;
      }

      return result;
    }
}
