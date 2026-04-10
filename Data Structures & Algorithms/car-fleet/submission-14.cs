public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<(int pos, double time)> list = new();
        for (int i = 0; i < position.Length; i++) {
            double time = (double)(target - position[i]) / speed[i];
            list.Add((position[i], time));
        }
        list.Sort((a, b) => b.pos.CompareTo(a.pos));

        Stack<double> stack = new();

        for (int i = 0; i < list.Count; i++) {
            if (stack.Count == 0 || list[i].time > stack.Peek()) {
                stack.Push(list[i].time);
            }
        }

        return stack.Count;
    }
}
