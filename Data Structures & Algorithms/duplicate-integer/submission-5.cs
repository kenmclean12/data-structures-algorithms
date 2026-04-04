public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (set.Contains(num)) {
                return true;
            }

            set.Add(num);
        }

        return false;
    }
}