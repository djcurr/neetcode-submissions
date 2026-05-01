class Solution:
    def fourSum(self, nums: List[int], target: int) -> List[List[int]]:
        n = len(nums)
        if n < 4:
            return []
        nums.sort()
        print(nums)
        out = []
        for i in range(n - 3):
            if i > 0 and nums[i] == nums[i-1]:
                continue
            for j in range(i+1,n-2):
                if j > i + 1 and nums[j] == nums[j-1]:
                    continue
                left, right = j + 1, n -1
                need = target - (nums[i] + nums[j])
                while left < right:
                    s = nums[left] + nums[right]
                    if s == need:
                        out.append([nums[i], nums[j], nums[left], nums[right]])
                        left += 1
                        right -= 1
                        while left < right and nums[left] == nums[left - 1]:
                            left += 1
                        while left < right and nums[right] == nums[right + 1]:
                            right -= 1
                    elif s < need:
                        left += 1
                    else:
                        right -= 1
                        
        return out