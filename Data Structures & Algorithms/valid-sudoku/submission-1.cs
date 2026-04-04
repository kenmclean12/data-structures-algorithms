public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char val = board[r][c];
                if (val == '.') continue;

                if (
                    !seen.Add($"{val} in row {r}") ||
                    !seen.Add($"{val} in col {c}") ||
                    !seen.Add($"{val} in box {r/3}-{c/3}")
                ) {
                    return false;
                }
            }
        }

        return true;
    }
}
