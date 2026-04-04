public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int result = 0;

        foreach (int num in nums) {
            if (!set.Contains(num - 1)) {
                int current = num;
                int length = 1;

                while (set.Contains(current + 1)) {
                    current++;
                    length++;
                }

                result = Math.Max(result, length);
            }
        }

        return result;
    }
}
