public class Solution {
    private int[] state;
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }

        foreach(var prereq in prerequisites) {
            var course = prereq[0];
            var prerequisite = prereq[1];
            graph[prerequisite].Add(course);
        }

        state = new int[numCourses];

        for (int i = 0; i < numCourses; i++) {
            if (!Dfs(graph, i)) return false;
        }

        return true;
    }

    private bool Dfs(List<int>[] graph, int course) {
        if (state[course] == 1) return false;
        if (state[course] == 2) return true;

        state[course] = 1;
        foreach(int next in graph[course]) {
            if (!Dfs(graph, next)) return false;
        }

        state[course] = 2;
        return true;
    }
}
