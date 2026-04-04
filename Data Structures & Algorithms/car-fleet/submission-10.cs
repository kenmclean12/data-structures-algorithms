public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        List<(int pos, double time)> cars = new();

        for (int i = 0; i < n; i++) {
            double time = (double)(target - position[i]) / speed[i];
            cars.Add((position[i], time));
        }

        cars.Sort((a, b) => b.pos.CompareTo(a.pos));

        Stack<double> stack = new();

        foreach (var car in cars) {
            if (stack.Count == 0 || car.time > stack.Peek()) {
                stack.Push(car.time);
            }
        }

        return stack.Count;
    }
}
