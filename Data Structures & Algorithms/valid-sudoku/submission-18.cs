public class Solution {
    public bool IsValidSudoku(char[][] board) {
       HashSet<string> set = new();

       for (int r = 0; r < board.Length; r++) {
          for (int c = 0; c < board[0].Length; c++) {
             char val = board[r][c];
             if (val == '.') continue;
             if (
               !set.Add($"{val} in row {r}") ||
               !set.Add($"{val} in col {c}") ||
               !set.Add($"{val} in box {r / 3} - {c / 3}")
             ) {
               return false;
             }
          }
       }

       return true;
    }
}
