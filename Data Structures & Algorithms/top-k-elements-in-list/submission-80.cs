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

        List<int>[] freqBuckets = new List<int>[nums.Length + 1];
        foreach (var pair in map) {
            int num = pair.Key;
            int freq = pair.Value;
            if (freqBuckets[freq] == null) {
                freqBuckets[freq] = new List<int>();
            }

            freqBuckets[freq].Add(num);
        }

        int[] result = new int[k];
        int resultIndex = 0;

        for (int i = freqBuckets.Length - 1; i >= 0; i--) {
            if (freqBuckets[i] != null && resultIndex < k) {
                foreach (int freq in freqBuckets[i]) {
                    result[resultIndex] = freq;
                    resultIndex++;
                    if (resultIndex == k) continue;
                }
            }
        }

        return result;
    }
}