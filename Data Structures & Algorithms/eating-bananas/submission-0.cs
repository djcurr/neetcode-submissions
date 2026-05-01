public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int f = 1;
        int l = piles.Max();
        while (f < l) {
            int mid = (f + l) / 2;
            if (calculateHours(piles, mid) <= h) {
                l = mid;
            } else {
                f = mid + 1;
            }
        }
        return f;
    }

    private int calculateHours(int[] piles, int h) {
        int hours = 0;
        for (int i = 0; i < piles.Length; i++) {
            hours += (piles[i] + h - 1) / h;
        }
        return hours;
    }
}
