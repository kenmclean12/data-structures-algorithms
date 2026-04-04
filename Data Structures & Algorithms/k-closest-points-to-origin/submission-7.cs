public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> queue = new();
        foreach (var point in points) {
            int x = point[0];
            int y = point[1];
            double distance = Math.Sqrt((x * x) + (y * y));
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
