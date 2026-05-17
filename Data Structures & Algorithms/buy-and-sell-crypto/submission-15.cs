public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        int minPrice = prices[0];
        int profit = 0;

        foreach(int price in prices) {
            int curProf = price - minPrice;
            minPrice = Math.Min(minPrice, price);
            profit = Math.Max(profit, curProf);
        }

        return profit;
    }
}
