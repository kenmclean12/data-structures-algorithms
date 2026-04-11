public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int r = 0;
        int c = cols - 1;

        while (r < rows && c >= 0) {
          if (matrix[r][c] == target) {
            return true;
          } else
          if (matrix[r][c] > target) {
            c--;
          } else {
            r++;
          }
        }

        return false;
    }
}
