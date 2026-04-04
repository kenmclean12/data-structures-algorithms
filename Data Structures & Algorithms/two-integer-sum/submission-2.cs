public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var seen = new Dictionary<int, int>();
       for (int i = 0; i < nums.Length; i++) {
          var num = nums[i];
          var needed = target - num;

          if (seen.ContainsKey(needed)) {
            return new[] { seen[needed], i };
          }

          seen[num] = i;
       }

       return Array.Empty<int>();
    }
}
