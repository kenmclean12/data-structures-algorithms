public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int result = 0;

        for (int i = 0; i < prices.Length; i++) {
            var price = prices[i];
            var profit = price - minPrice;
            result = Math.Max(result, profit);
            minPrice = Math.Min(minPrice, price);
        }

        return result;
    }
}
