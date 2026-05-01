public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) (nums1, nums2) = (nums2, nums1);
        int m = nums1.Length;
        int n = nums2.Length;

        int half = (m + n + 1) / 2;

        int f = 0;
        int l = m;
        while (f <= l) {
            int mid = (f + l) / 2;
            int bTake = half - mid;

            int maxA = mid == 0 ? int.MinValue : nums1[mid - 1];
            int minA = mid == m ? int.MaxValue : nums1[mid];
            int maxB = bTake == 0 ? int.MinValue : nums2[bTake - 1];
            int minB = bTake == n ? int.MaxValue : nums2[bTake];

            if (maxA <= minB && maxB <= minA) {
                if (((m + n) % 2) == 1) {
                    return Math.Max(maxA, maxB);
                } else {
                    return (Math.Max(maxA, maxB) + Math.Min(minA, minB)) / 2.0;
                }
            }

            if (maxA > minB) l = mid - 1;
            else f = mid + 1;
        }
        return 0;
    }
}
