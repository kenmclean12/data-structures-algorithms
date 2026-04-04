public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            if (seen.Contains(num)) {
                return true;
            }

            seen.Add(num);
        }

        return false;
    }
}