public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;

        for (int r = 0; r < grid.Length; r++) {
            for (int c = 0; c < grid[0].Length; c++) {
                if (grid[r][c] == 1) {
                    max = Math.Max(max, Dfs(grid, r, c));
                }
            }
        }

        return max;
    }

    private int Dfs(int[][] grid, int r, int c) {
        if (
            r < 0 ||
            r >= grid.Length ||
            c < 0 ||
            c >= grid[0].Length ||
            grid[r][c] == 0
        ) {
            return 0;
        }

        grid[r][c] = 0;

        int area = 1;

        area += Dfs(grid, r + 1, c);
        area += Dfs(grid, r - 1, c);
        area += Dfs(grid, r, c + 1);
        area += Dfs(grid, r, c - 1);

        return area;
    }
}
