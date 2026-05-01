public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // BSearch on Rows
        // BSearch within Row
        int n = matrix[0].Length - 1;
        int f = 0;
        int l = matrix.Length - 1;
        
        while (l - f > 0) {
            int mid = (f + l) / 2;

            if (target > matrix[mid][n]) {
                f = mid + 1;
            } else {
                l = mid;
            }
        }
        var row = f;
        if (target < matrix[row][0] || target > matrix[row][n]) return false;
        // [1-7], [10-20], [23-60], x = 13
        f = 0;
        l = n;
        while (l - f > 0) {
            int mid = (f + l) / 2;

            if (target > matrix[row][mid]) {
                f = mid + 1;
            } else {
                l = mid;
            }
        }
        return matrix[row][l] == target;
    }
}
