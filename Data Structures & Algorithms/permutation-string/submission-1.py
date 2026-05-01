class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        n1 = len(s1)
        n2 = len(s2)
        c1 = Counter(s1)
        for i in range(0, n2):
            c2 = Counter(s2[i:i+n1])
            print(c2)
            print(c1)
            if c2 == c1:
                return True
        return False
