public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int result = 0;

        foreach (int num in nums) {
            if (!set.Contains(num - 1)) {
                int current = num;
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
