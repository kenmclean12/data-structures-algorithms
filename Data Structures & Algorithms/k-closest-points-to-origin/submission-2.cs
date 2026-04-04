public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> queue = new();
        foreach (var point in points) {
            int x = point[0];
            int y = point[1];
            int distance = ((x * x) + (y * y));
            queue.Enqueue(point, -distance);

            if (queue.Count > k) {
                queue.Dequeue();
            }
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++) {
            result[i] = queue.Dequeue();
        }

        return result;
    }
}
