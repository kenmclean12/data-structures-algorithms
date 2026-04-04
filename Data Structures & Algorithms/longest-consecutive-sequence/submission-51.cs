public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int maxLength = 0;

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            if (!set.Contains(num - 1)) {
                int length = 1;
                int current = num;

                while (set.Contains(current + 1)) {
                    current++;
                    length++;
                }

                maxLength = Math.Max(maxLength, length);
            }
        }

        return maxLength;
    }
}
