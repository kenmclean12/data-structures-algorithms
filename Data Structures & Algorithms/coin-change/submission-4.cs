public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];
        for (int i = 1; i <= amount; i++) {
            dp[i] = amount + 1;
        }

        dp[0] = 0;

        for (int a = 1; a <= amount; a++) {
            foreach(int coin in coins) {
                if (coin <= a) {
                    dp[a] = Math.Min(dp[a], 1 + dp[a - coin]);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}