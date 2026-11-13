public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1) return 0;
        int minPrice = prices[0];
        int result = 0;

        for (int i = 1; i < prices.Length; i++) {
            int prof = prices[i] - minPrice;
            result = Math.Max(result, prof);
            minPrice = Math.Min(minPrice, prices[i]);
        }

        return result;
    }
}
