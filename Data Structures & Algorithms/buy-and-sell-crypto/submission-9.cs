public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++) {
            int price = prices[i];
            int profit = price - minPrice;
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }
}
