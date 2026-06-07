public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++) {
          int num = nums[i];
          int needed = target - num;

          if (map.ContainsKey(needed)) {
            return new int[] { map[needed], i };
          }

          map[num] = i;
        }

        return Array.Empty<int>();
    }
}
