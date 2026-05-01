public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 1) return s.Length;
        HashSet<char> seen = new();
        int longest = 0;
        int f = 0;
        int l = 1;
        seen.Add(s[f]);
        while (l < s.Length) {
            if (seen.Contains(s[l])) {
                seen.Remove(s[f]);
                f++;
            } else {
                seen.Add(s[l]);
                l++;
                longest = Math.Max(longest, l - f);
            }
        }
        return longest;
    }
}
