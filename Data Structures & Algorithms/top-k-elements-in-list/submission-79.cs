public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Step 1: Build the frequency map O(n)
        Dictionary<int, int> map = new();
        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 1;
            } else {
                map[num]++;
            }
        }

        // Step 2: Create buckets where index = frequency O(n)
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in map) {
            int frequency = pair.Value;
            if (buckets[frequency] == null) {
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(pair.Key);
        }

        // Step 3: Gather the top k elements from the buckets O(n)
        int[] result = new int[k];
        int resultIndex = 0;

        for (int i = buckets.Length - 1; i >= 0 && resultIndex < k; i--) {
            if (buckets[i] != null) {
                foreach (int num in buckets[i]) {
                    result[resultIndex++] = num;
                    if (resultIndex == k) break;
                }
            }
        }

        return result;
    }
}