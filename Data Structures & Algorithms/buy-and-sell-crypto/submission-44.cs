public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0 || prices.Length == 1) return 0;
        int minPrice = prices[0];
        int result = 0;

        for (int i = 1; i < prices.Length; i++) {
            int profit = prices[i] - minPrice;
            result = Math.Max(result, profit);
            minPrice = Math.Min(minPrice, prices[i]);
        }

        return result;
    }
}
