class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        stack = []
        out = [0] * len(temperatures)
        for i in range(len(temperatures)):
            while stack:
                if stack[-1][0] < temperatures[i]:
                    num, j = stack.pop()
                    out[j] = i - j
                else:
                    break
            stack.append((temperatures[i], i))
        return out