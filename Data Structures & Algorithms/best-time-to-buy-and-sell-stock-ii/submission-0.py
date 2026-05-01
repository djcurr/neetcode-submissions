class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        left = 0
        profit = 0
        for right in range(len(prices)):
            if prices[right] < prices[left]:
                left = right
            else:
                if right == len(prices) - 1 or prices[right + 1] < prices[right]:
                    profit += prices[right] - prices[left]
                    left = right
        return profit