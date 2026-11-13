public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
      List<(double time, int pos)> list = new();
      for (int i = 0; i < position.Length; i++) {
        double time = (double)(target - position[i]) / speed[i];
        list.Add((time, position[i]));
      }

      list.Sort((a, b) => b.pos.CompareTo(a.pos));

      Stack<double> stack = new();
      foreach (var car in list) {
        if (stack.Count == 0 || car.time > stack.Peek()) {
            stack.Push(car.time);
        }
      }

      return stack.Count;
    }
}
