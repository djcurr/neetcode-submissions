public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1) return 0;
        int maxP = 0;
        int minSoFar = prices[0];
        for (int i = 1; i < prices.Length; i++) {
            maxP = Math.Max(maxP, prices[i] - minSoFar);
            minSoFar = Math.Min(minSoFar, prices[i]);
        }
        return maxP;
    }
}
