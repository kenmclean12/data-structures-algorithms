public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> seen = new();

        for (int i = 0; i < nums.Length; i++) {
            if (seen.Contains(nums[i])) return nums[i];
            seen.Add(nums[i]);
        }

        return -1;
    }
}
