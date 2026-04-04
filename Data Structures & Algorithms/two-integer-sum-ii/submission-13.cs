public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++) {
            int num = numbers[i];
            int needed = target - num;

            if (seen.ContainsKey(needed)) {
                return new int[] { seen[needed], i + 1 };
            }

            seen[num] = i + 1;
        }

        return Array.Empty<int>();
    }
}
