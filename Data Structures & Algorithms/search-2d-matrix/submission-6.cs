public class Solution {
public bool SearchMatrix(int[][] matrix, int target) {
    if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return false;
    int m = matrix.Length, n = matrix[0].Length;

    int r = 0, c = n - 1; // start top-right
    while (r < m && c >= 0) {
        int val = matrix[r][c];
        if (val == target) return true;
        if (val > target) c--;   // move left to smaller values
        else r++;                // move down to larger values
    }
    return false;
}

}
