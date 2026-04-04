public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int prev2 = nums[0];
        int prev1 = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++) {
            int mostMoney = Math.Max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = mostMoney;
        }

        return prev1;
    }
}
