public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (seen.Contains(num)) {
                return true;
            } else {
                seen.Add(num);
            }
        }

        return false;
    }
}