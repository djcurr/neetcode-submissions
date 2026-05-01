class Solution:
    def simplifyPath(self, path: str) -> str:
        split_path = path.split('/')
        stack = []
        for i, path in enumerate(split_path):
            print(path)
            if path == '.' or path == '':
                pass
            elif path == '..':
                if stack:
                    stack.pop()
            else:
                stack.append(path)
        return "/" + "/".join(stack)
