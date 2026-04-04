public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int profit = 0;

        for (int i = 0; i < prices.Length; i++) {
            var price = prices[i];
            var currentProfit = price - minPrice;
            profit = Math.Max(profit, currentProfit);
            minPrice = Math.Min(minPrice, price);
        }

        return profit;
    }
}
