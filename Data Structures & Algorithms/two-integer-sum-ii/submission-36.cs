public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
      Dictionary<int, int> map = new();
      for (int i = 0; i < numbers.Length; i++) {
        int num = numbers[i];
        int needed = target - num;
        if (map.ContainsKey(needed)) {
            return new int[] { map[needed], i + 1 };
        }

        map[num] = i + 1;
      }

      return Array.Empty<int>();
    }
}
