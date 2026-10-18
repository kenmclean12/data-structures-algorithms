public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 1;
            } else {
                map[num]++;
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in map) {
            int freq = pair.Value;
            int val = pair.Key;

            if (buckets[freq] == null) buckets[freq] = new List<int>();
            buckets[freq].Add(val);
        }

        int[] result = new int[k];
        int resultIndex = 0;

        for (int i = buckets.Length - 1; i >= 0; i--) {
            List<int> bucket = buckets[i];
            if (bucket != null && resultIndex < k) {
                foreach (int val in bucket) {
                    result[resultIndex] = val;
                    resultIndex++;
                    if (resultIndex == k - 1) continue;
                }
            }
        }

        return result;
    }
}