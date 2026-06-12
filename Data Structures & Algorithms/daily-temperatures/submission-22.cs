public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       int n = temperatures.Length;
       int[] result = new int[n];
       Stack<int> stack = new();

       for (int i = 0; i < temperatures.Length; i++) {
          int temp = temperatures[i];
          while (stack.Count > 0 && temp > temperatures[stack.Peek()]) {
            int prevIndex = stack.Pop();
            result[prevIndex] = i - prevIndex;
          }

          stack.Push(i);
       }

       return result;
    }
}
