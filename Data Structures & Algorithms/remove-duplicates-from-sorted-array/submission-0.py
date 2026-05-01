class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        i = 0
        j = 0
        n = len(nums)
        while j < n:
            while j < n and nums[i] == nums[j]:
                j += 1
            i += 1
            if j < n:
                nums[i] = nums[j]
        return i