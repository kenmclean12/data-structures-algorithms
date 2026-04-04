public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == '1') {
                    islands++;
                    Dfs(grid, r, c);
                }
            }
        }

        return islands;
    }

    private void Dfs(char[][] grid, int r, int c) {
        if (
            r < 0 ||
            r >= grid.Length ||
            c < 0 ||
            c >= grid[0].Length ||
            grid[r][c] == '0'
        ) {
            return;
        }

        grid[r][c] = '0';

        Dfs(grid, r + 1, c);
        Dfs(grid, r - 1, c);
        Dfs(grid, r, c + 1);
        Dfs(grid, r, c - 1);
    }
}
