public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
      int rows = matrix.Length;
      int cols = matrix[0].Length;

      int r = 0;
      int c = cols - 1;

      while (r < rows && c >= 0) {
        int val = matrix[r][c];
        if (val == target) return true;
        if (val > target) {
          c--;
        } else {
          r++;
        }
      }

      return false;
    }
}
