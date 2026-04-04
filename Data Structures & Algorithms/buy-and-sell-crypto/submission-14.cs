public class Solution {
    public int MaxProfit(int[] prices) {
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
