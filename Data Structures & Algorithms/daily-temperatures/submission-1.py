class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        stack = []
        out = [0] * len(temperatures)
        for i in range(len(temperatures)):
            while stack:
                if temperatures[stack[-1]] < temperatures[i]:
                    j = stack.pop()
                    out[j] = i - j
                else:
                    break
            stack.append(i)
        return out