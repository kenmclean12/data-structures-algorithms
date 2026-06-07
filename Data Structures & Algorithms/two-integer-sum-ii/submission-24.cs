public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> map = new();

        for (int i = 0; i < numbers.Length; i++) {
          int needed = target - numbers[i];
          if (map.ContainsKey(needed)) {
            return new int[] { map[needed], i + 1 };
          }

          map[numbers[i]] = i + 1;
        }

        return Array.Empty<int>();
    }
}
