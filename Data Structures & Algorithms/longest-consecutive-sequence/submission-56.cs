public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int result = 0;

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            if (!set.Contains(nums[i] - 1)) {
                int current = num;
                int count = 1;

                while (set.Contains(current + 1)) {
                    current++;
                    count++;
                }

                result = Math.Max(result, count);
            }
        }

        return result;
    }
}
