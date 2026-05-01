class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        n = len(s)
        if n == 1:
            return 1
        max_len = 0
        i = 0
        counts = Counter()
        for j in range(n):
            counts[s[j]] += 1
            letter, c = counts.most_common(1)[0]
            while j - i + 1 - c > k:
                counts[s[i]] -= 1
                i += 1
            max_len = max(max_len, j - i + 1)
        return max_len
            
