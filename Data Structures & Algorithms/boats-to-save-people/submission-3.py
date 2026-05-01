class Solution:
    def numRescueBoats(self, people: List[int], limit: int) -> int:
        # pairs of numbers closest to limit
        people.sort()
        left = 0
        right = len(people) - 1
        boats = 0
        while left < right:
            if people[right] + people[left] <= limit:
                left += 1
            right -= 1
            boats += 1
        if left == right:
            boats += 1
        return boats
            