public class Solution {
    public bool hasDuplicate(int[] nums) {
      var hashSet = new HashSet<int>();
      for (int i = 0; i < nums.Length; i++) {
         int num = nums[i];
         if (hashSet.Contains(num)) {
            return true;
         }

         hashSet.Add(num);
      }


      return false;
    }
}