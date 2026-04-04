public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        int currentLength = 1;
        int maxLength = 1;

        for (int i = 1; i < nums.Length; i++) {
            var num = nums[i];
            if (num == nums[i - 1]) continue;
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
