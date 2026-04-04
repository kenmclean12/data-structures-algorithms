public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int result = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (!set.Contains(nums[i] - 1)) {
                int current = nums[i];
                int len = 1;

                while (set.Contains(current + 1)) {
                    current++;
                    len++;
                }

                result = Math.Max(result, len);
            }
        }

        return result;
    }
}
