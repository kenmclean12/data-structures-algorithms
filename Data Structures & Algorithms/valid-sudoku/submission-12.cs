public class Solution {
    public bool IsValidSudoku(char[][] board) {
       HashSet<string> set = new();

       for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char character = board[r][c];
                if (character == '.') continue;

                if (
                    !set.Add($"{character} in row {r}") ||
                    !set.Add($"{character} in col {c}") ||
                    !set.Add($"{character} in box {r/3}-{c/3}")
                ) {
                    return false;
                }
            }
       }

       return true;
    }
}
