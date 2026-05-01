class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        left = 0
        min_len = float("inf")
        cur = 0
        for right in range(len(nums)):
            cur += nums[right]
            while cur >= target:
                min_len = min(min_len, right - left + 1)
                cur -= nums[left]
                left += 1
        return int(min_len) if min_len < float('inf') else 0