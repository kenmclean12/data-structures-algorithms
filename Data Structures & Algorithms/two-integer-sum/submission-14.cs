public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      Dictionary<int, int> seen = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++) {
         int num = nums[i];
         int needed = target - num;

         if (seen.ContainsKey(needed)) {
            return new int[] { seen[needed], i };
         }

         seen[num] = i;
      }

      return Array.Empty<int>();
    }
}
