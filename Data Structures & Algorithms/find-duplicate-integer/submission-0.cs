public class Solution {
    public int FindDuplicate(int[] nums) {
        foreach (var num in nums) {
            if (nums[Math.Abs(num) - 1] < 0) return Math.Abs(num);
            nums[Math.Abs(num) - 1] *= -1;
        }
        return 0;
    }
}
