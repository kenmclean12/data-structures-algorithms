public class Solution {
    HashSet<(int r, int c)> visitedPacific = new HashSet<(int, int)>();
    HashSet<(int r, int c)> visitedAtlantic = new HashSet<(int, int)>();
    public List<List<int>> PacificAtlantic(int[][] heights) {
        List<(int r, int c)> pacificStart = new List<(int, int)>();
        List<(int r, int c)> atlanticStart = new List<(int, int)>();
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < heights[0].Length; i++) {
            pacificStart.Add((0, i));
            atlanticStart.Add((heights.Length - 1, i));
        }

        for (int i = 0; i < heights.Length; i++) {
            pacificStart.Add((i, 0));
            atlanticStart.Add((i, heights[0].Length - 1));
        }

        for (int i = 0; i < pacificStart.Count; i++) {
            Dfs(heights, pacificStart[i].r, pacificStart[i].c, 0, true);
        }

        for (int i = 0; i < atlanticStart.Count; i++) {
            Dfs(heights, atlanticStart[i].r, atlanticStart[i].c, 0, false);
        }
        
        for (int r = 0; r < heights.Length; r++) {
            for (int c = 0; c < heights[0].Length; c++) {
                if (visitedPacific.Contains((r, c)) && visitedAtlantic.Contains((r, c))) {
                    result.Add(new List<int> { r, c });
                }
            }
        }

        return result;
    }

    private void Dfs(int[][] heights, int r, int c, int lastHeight, bool isPacific) {
        HashSet<(int r, int c)> visited = isPacific ? visitedPacific : visitedAtlantic;
        if (
            r < 0 ||
            r >= heights.Length ||
            c < 0 ||
            c >= heights[0].Length ||
            visited.Contains((r, c)) ||
            heights[r][c] < lastHeight
        ) {
            return;
        }

        visited.Add((r, c));

        Dfs(heights, r + 1, c, heights[r][c], isPacific);
        Dfs(heights, r - 1, c, heights[r][c], isPacific);
        Dfs(heights, r, c + 1, heights[r][c], isPacific);
        Dfs(heights, r, c - 1, heights[r][c], isPacific);
    }
}
