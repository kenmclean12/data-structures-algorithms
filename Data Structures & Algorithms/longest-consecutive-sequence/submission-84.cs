public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> set = new(nums);
       int result = 0;

       foreach (int num in nums) {
         if (!set.Contains(num - 1)) {
            int curr = num;
            int total = 1;

            while (set.Contains(curr + 1)) {
               curr++;
               total++;
            }

            result = Math.Max(result, total);
         }
       }

       return result;
    }
}
