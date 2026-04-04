public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        int currentLength = 1;
        int maxLength = 1;

        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (i == 0 || num == nums[i - 1]) {
                continue;
            } else
            if (num == nums[i - 1] + 1) {
                currentLength++;
            } else {
                currentLength = 1;
            }

            maxLength = Math.Max(maxLength, currentLength);
        }

        return maxLength;
    }
}
