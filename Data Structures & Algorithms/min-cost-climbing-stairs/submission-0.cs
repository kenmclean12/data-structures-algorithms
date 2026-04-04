public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        if (n == 0) return 0;
        if (n == 1) return cost[0];

        int prev2 = cost[0];
        int prev1 = cost[1];

        for (int i = 2; i < n; i++) {
            int least = cost[i] + Math.Min(prev1, prev2);
            prev2 = prev1;
            prev1 = least;
        }

        return Math.Min(prev1, prev2);
    }
}
