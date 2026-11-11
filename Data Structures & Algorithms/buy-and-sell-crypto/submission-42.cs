public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (int price in prices) {
            int profit = price - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
            minPrice = Math.Min(minPrice, price);
        }

        return maxProfit;
    }
}
