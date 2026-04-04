public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> queue = new();
        foreach (int stone in stones) {
            queue.Enqueue(stone, -stone);
        }

        while (queue.Count > 1) {
           int y = queue.Dequeue();
           int x = queue.Dequeue();

           if (y != x) {
                int newStone = y - x;
                queue.Enqueue(newStone, -newStone);
           }
        }

        return queue.Count == 0 ? 0 : queue.Peek();
    }
}
