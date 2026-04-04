public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        var left = 0;
        var current = 1;
        var longest = 1;

        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (i == 0 || num == nums[i - 1]) {
                continue;
            } else
            if (num == nums[i - 1] + 1) {
                current++;
            } else {
                current = 1;
            }

            longest = Math.Max(longest, current);
        }

        return longest;
    }
}
