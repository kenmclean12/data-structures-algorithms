public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seen = new(nums);
        int result = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (!seen.Contains(nums[i] - 1)) {
                int current = nums[i];
                int length = 1;

                while (seen.Contains(current + 1)) {
                    current++;
                    length++;
                }

                result = Math.Max(result, length);
            }
        }

        return result;
    }
}
