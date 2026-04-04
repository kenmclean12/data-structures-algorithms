public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var map = new Dictionary<int, int>();
       for (int i = 0; i < nums.Length; i++) {
         var num = nums[i];
         var needed = target - num;

         if (map.ContainsKey(needed)) {
            return new[] { map[needed], i };
         }

         map[num] = i;
       }

       return Array.Empty<int>();
    }
}
